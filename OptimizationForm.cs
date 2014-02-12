using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CourseWork.Properties;
using ELW.Library.Math;
using ELW.Library.Math.Exceptions;
using ELW.Library.Math.Expressions;
using ELW.Library.Math.Tools;

namespace CourseWork
{
    public partial class OptimizationForm : Form
    {
        public static double Accuracy;
        public int Enlarged = 0;
        public bool IsInfinity;
        public float Zoom = 50; // Начальный масштаб
        private CompiledExpression _compiledExpression;
        private Graph _graph;
        private Graph _graphOpt;
        private ObservableCollection<PointF> _chart = new ObservableCollection<PointF>();

        public OptimizationForm()
        {
            InitializeComponent();
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality; // Устанавливает высокий уровень сглаживания
            using (Pen pGrid = new Pen(Color.Black), pMainF = new Pen(Color.Blue))
            {
                // Рисует оси координат
                var mat = new Matrix(1, 0, 0, -1, 0, 0); // отражение
                mat.Translate(pic.Width/2, pic.Height/2, MatrixOrder.Append);
                e.Graphics.DrawLine(pGrid, pic.Width/2, 0, pic.Width/2, pic.Height);
                e.Graphics.DrawLine(pGrid, 0, pic.Height/2, pic.Width, pic.Height/2);
                e.Graphics.MultiplyTransform(mat);
                if (_graph != null)
                    e.Graphics.DrawLines(pMainF, _graph.Coords); // Рисует линии
                if (_graphOpt != null)
                    DrawPoints(e, _graphOpt); // Рисует точки
            }
        }

        public void DrawPoints(PaintEventArgs e, Graph dr)
        {
            for (int i = 0; i < dr.Coords.Length; i++)
            {
                if (i == Enlarged) continue;
                e.Graphics.FillEllipse(new SolidBrush(dr.DyeColor), dr.Coords[i].X*Zoom - 2, dr.Coords[i].Y*Zoom - 2, 4,
                    4);
            }
            e.Graphics.FillEllipse(new SolidBrush(Color.Brown), dr.Coords[Enlarged].X*Zoom - 4,
                dr.Coords[Enlarged].Y*Zoom - 4, 8, 8);
        }

        private ObservableCollection<PointF> BuildObjectiveFunction(CompiledExpression compiledExpression)
        {
            int c = 0;
            var coords = new ObservableCollection<PointF>();
            for (float x = 0 - pic.Width/2; x < pic.Width/2; x++)
            {
                var variable = new VariableValue((double) x/Zoom, "x");
                var fx = (float) ToolsHelper.Calculator.Calculate(compiledExpression, variable);
                if (float.IsInfinity(fx) || float.IsNaN(fx))
                {
                    IsInfinity = true;
                    continue;
                }
                coords.Add(new PointF(x, fx*Zoom));
                c++;
            }
            return coords;
        }

        private static PointF[] ConvertToArray(ObservableCollection<PointF> coords)
        {
            var arr = new PointF[coords.Count];
            for (int i = 0; i < coords.Count; i++)
            {
                arr[i].X = coords[i].X;
                arr[i].Y = coords[i].Y;
            }
            return arr;
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            dgvResult.Rows.Clear();
            _chart = new ObservableCollection<PointF>(); // Очистка данных
            // Компиляция функции
            _compiledExpression = СompileExpression();
            _graph = new Graph(Color.Blue, ConvertToArray(BuildObjectiveFunction(_compiledExpression)));
            // Считывание интервалов

            if (rbDichotomy.Checked || rbFibonacci.Checked || rbGold.Checked || rbNewton.Checked)
            {
                // Задание интервалов для функции
                FunctionLimits.Set((double) nudLeftInterval.Value, (double) nudRightInterval.Value);

                // Задание точности для функции
                try
                {
                    Accuracy = Convert.ToDouble(tbAccuracy.Text);
                    if (Accuracy <= 0) MessageBox.Show(Resources.AccuracyWarning);
                }
                catch
                {
                    MessageBox.Show(Resources.IncorrectAccuracy);
                    return;
                }

                // Выполнение оптимизации
                if (rbDichotomy.Checked) _chart = Methods.Dichotomy(_compiledExpression); // Вызывает метод Дихотомии
                if (rbFibonacci.Checked) _chart = Methods.Fibonacci(_compiledExpression); // Вызывает метод Фибоначчи
                if (rbGold.Checked) _chart = Methods.Gold(_compiledExpression); // Вызывает метод золотого сечения
                if (rbNewton.Checked) _chart = Methods.Newton(_compiledExpression); // Вызывает метод Ньютона
                if (_chart == null) return;
                // Инициализирует график итераций оптимизации
                _graphOpt = new Graph(Color.Red, ConvertToArray(_chart));
                Enlarged = _chart.Count - 1;
                if (IsInfinity) lblResultX.Text = "∞"; // Проверка на бесконечность
                else
                {
                    lblResultX.Text = Resources.X + _chart[_chart.Count - 1].X;
                    lblResultY.Text = Resources.Y + _chart[_chart.Count - 1].Y;
                }
                // Заполнение таблицы координат
                foreach (var t in _chart)
                    dgvResult.Rows.Add(t.X, t.Y);
            }
            pic.Refresh();
            btnZoomIn.Enabled = true;
            btnZoomOut.Enabled = true;
        }

        private CompiledExpression СompileExpression()
        {
            try
            {
                // Compiling an expression
                PreparedExpression preparedExpression = ToolsHelper.Parser.Parse(rtbFunc.Text);
                _compiledExpression = ToolsHelper.Compiler.Compile(preparedExpression);
            }
            catch (CompilerSyntaxException ex)
            {
                MessageBox.Show(String.Format("Синтаксическая ошибка: {0}", ex.Message));
            }
            catch (MathProcessorException ex)
            {
                MessageBox.Show(String.Format("Ошибка: {0}", ex.Message));
            }
            catch (ArgumentException)
            {
                MessageBox.Show(Resources.DataInputError);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.UnknownError);
                throw;
            }
            return _compiledExpression;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rbDichotomy.Checked = false;
            rbFibonacci.Checked = false;
            rbGold.Checked = false;
            rbNewton.Checked = false;
            _chart.Clear();
            dgvResult.Rows.Clear();
            _graph = null;
            _graphOpt = null;
            pic.Refresh();
            btnZoomIn.Enabled = false;
            btnZoomOut.Enabled = false;
            lblResultX.Text = Resources.X;
            lblResultY.Text = Resources.Y;
        }

        private void dgvResult_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResult.SelectedRows.Count != 0)
                Enlarged = dgvResult.SelectedRows[0].Index;
            pic.Refresh();
        }

        private void btnZoonOut_Click(object sender, EventArgs e)
        {
            try
            {
                Zoom /= 2;
                _graph = new Graph(Color.Blue, ConvertToArray(BuildObjectiveFunction(_compiledExpression)));
                if (_chart.Count > 0)
                {
                    _graphOpt = new Graph(Color.Red, ConvertToArray(_chart));
                    Enlarged = dgvResult.SelectedRows[0].Index;
                }
            }
            catch
            {
                MessageBox.Show(Resources.ZoomError);
                btnZoomOut.Enabled = false;
            }
            pic.Refresh();
        }

        private void btnZoonIn_Click(object sender, EventArgs e)
        {
            try
            {
                Zoom *= 2;
                _graph = new Graph(Color.Blue, ConvertToArray(BuildObjectiveFunction(_compiledExpression)));
                if (_chart.Count > 0)
                {
                    _graphOpt = new Graph(Color.Red, ConvertToArray(_chart));
                    Enlarged = dgvResult.SelectedRows[0].Index;
                }
            }
            catch
            {
                MessageBox.Show(Resources.ZoomError);
                btnZoomIn.Enabled = false;
            }
            pic.Refresh();
        }

        private void Optimization_Resize(object sender, EventArgs e)
        {
            dgvResult.Height = Size.Height - 93;
            pic.Width = Size.Width - 212;
            pic.Height = Size.Height - 155;
            pic.Refresh();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string resStr = string.Empty;
            for (int i = 0; i < dgvResult.Rows.Count; i++)
            {
                resStr += i + 1 + "|" + dgvResult.Rows[i].Cells[0].Value + "|" + dgvResult.Rows[i].Cells[1].Value +
                          Environment.NewLine;
            }
            Clipboard.SetDataObject(resStr);
        }
    }

    internal static class FunctionLimits
    {
        public static double Left;
        public static double Right;

        public static double Length
        {
            get { return Right - Left; }
        }

        public static void Set(double l, double r)
        {
            Left = l;
            Right = r;
        }
    }
}
using System;
using System.Collections.ObjectModel;
using System.Drawing;
using ELW.Library.Math;
using ELW.Library.Math.Expressions;
using ELW.Library.Math.Tools;

namespace CourseWork
{
    public class Methods
    {
        public static ObservableCollection<PointF> Dichotomy(CompiledExpression compiledExpression)
        {
            //������� ��������� ����� ��� �������
            var chart = new ObservableCollection<PointF>();

            double step = OptimizationForm.Accuracy/4;
            while (FunctionLimits.Length >= OptimizationForm.Accuracy)
            {
                double x1 = (FunctionLimits.Left + FunctionLimits.Right)/2 - step;
                double x2 = (FunctionLimits.Left + FunctionLimits.Right)/2 + step;
                var variable = new VariableValue(x1, "x");
                double fx1 = ToolsHelper.Calculator.Calculate(compiledExpression, variable);
                variable = new VariableValue(x2, "x");
                double fx2 = ToolsHelper.Calculator.Calculate(compiledExpression, variable);

                if (fx1 > fx2)
                {
                    FunctionLimits.Left = x1; //�������� ����� ������� � ����� x1
                }
                else
                {
                    FunctionLimits.Right = x2; //����� �������� ������ ������� � ����� �2
                }
                //��������� ����� � ���������
                chart.Add(new PointF {X = (float) x1, Y = (float) fx1});
                chart.Add(new PointF {X = (float) x2, Y = (float) fx2});
            }
            return chart;
        }

        public static ObservableCollection<PointF> Gold(CompiledExpression compiledExpression)
        {
            //������� ��������� ����� ��� �������
            var Chart = new ObservableCollection<PointF>();
            //������������� ����������
            const double a = 0.618;
            //���������������� ����, ������������ ��������� �������� ����� �1,�2 � �������� ������� � ���� ������
            double x1 = FunctionLimits.Left + (1 - a)*FunctionLimits.Length;
            double x2 = FunctionLimits.Left + a*FunctionLimits.Length;
            //��������� �������� ������� � ���� ������
            var variable = new VariableValue(x1, "x");
            double fx1 = ToolsHelper.Calculator.Calculate(compiledExpression, variable);
            variable = new VariableValue(x2, "x");
            double fx2 = ToolsHelper.Calculator.Calculate(compiledExpression, variable);
            //��������� ��������� ����� � ������
            Chart.Add(new PointF {X = (float) x1, Y = (float) fx1});
            Chart.Add(new PointF {X = (float) x2, Y = (float) fx2});
            //�� ��� ��� ���� ����� ��������� ������ ������ - ���������
            while (FunctionLimits.Length >= OptimizationForm.Accuracy)
            {
                //���� ������ �������� ������
                if (fx1 > fx2)
                {
                    //�������� ����� ������� � ����� x1
                    FunctionLimits.Left = x1;
                    //��������� ����� �2, ��� ����� ������������ � ��������� ��������
                    x1 = x2;
                    //��������� �������� ������� � �����
                    fx1 = fx2;
                    //������������ ��� ���� �����
                    x2 = FunctionLimits.Left + a*FunctionLimits.Length;
                    //������������ �������� ������� � �����
                    variable = new VariableValue(x2, "x");
                    fx2 = ToolsHelper.Calculator.Calculate(compiledExpression, variable);
                    //��������� � ��������� ����� ��� �������
                    Chart.Add(new PointF {X = (float) x2, Y = (float) fx2});
                }
                else
                {
                    //����� �������� ������ ������� � ����� x2
                    FunctionLimits.Right = x2;
                    //��������� ����� �1, ��� ����� ������������ � ��������� ��������
                    x2 = x1;
                    //��������� �������� ������� � �����
                    fx2 = fx1;
                    //������������ ��� ���� �����
                    x1 = FunctionLimits.Left + (1 - a)*FunctionLimits.Length;
                    //������������ �������� ������� � �����
                    variable = new VariableValue(x1, "x");
                    fx1 = ToolsHelper.Calculator.Calculate(compiledExpression, variable);
                    //��������� � ��������� ����� ��� �������
                    Chart.Add(new PointF {X = (float) x1, Y = (float) fx1});
                }
            }
            return Chart;
        }

        private static double FibNum(double num)
        {
            if (num <= 1) return num;
            return (FibNum(num - 1) + FibNum(num - 2));
        }

        public static ObservableCollection<PointF> Fibonacci(CompiledExpression compiledExpression)
        {
            var chart = new ObservableCollection<PointF>();
            int counter = 1;
            double n = 0;
            double threshold = FunctionLimits.Length/OptimizationForm.Accuracy;

            //Speedometer.Start();
            while (FibNum(n) <= threshold)
                n++;

            double x1 = FunctionLimits.Left + (FibNum(n - 2)/FibNum(n))*FunctionLimits.Length;
            double x2 = FunctionLimits.Left + (FibNum(n - 1)/FibNum(n))*FunctionLimits.Length;
            var variable = new VariableValue(x1, "x");
            double fx1 = ToolsHelper.Calculator.Calculate(compiledExpression, variable);
            variable = new VariableValue(x2, "x");
            double fx2 = ToolsHelper.Calculator.Calculate(compiledExpression, variable);
            chart.Add(new PointF {X = (float) x1, Y = (float) fx1});
            chart.Add(new PointF {X = (float) x2, Y = (float) fx2});

            while (true)
            {
                if (fx1 > fx2)
                {
                    FunctionLimits.Left = x1;
                    x1 = x2;
                    fx1 = fx2;
                    x2 = FunctionLimits.Left + (FibNum(n - 1 - counter)/FibNum(n - counter))*FunctionLimits.Length;
                    variable = new VariableValue(x2, "x");
                    fx2 = ToolsHelper.Calculator.Calculate(compiledExpression, variable);
                    chart.Add(new PointF {X = (float) x2, Y = (float) fx2});
                }
                else
                {
                    FunctionLimits.Right = x2;
                    x2 = x1;
                    fx2 = fx1;
                    x1 = FunctionLimits.Left + (FibNum(n - 2 - counter)/FibNum(n - counter))*FunctionLimits.Length;
                    variable = new VariableValue(x1, "x");
                    fx1 = ToolsHelper.Calculator.Calculate(compiledExpression, variable);
                    chart.Add(new PointF {X = (float) x1, Y = (float) fx1});
                }
                counter++;
                if (counter == n - 2) break;
            }
            //Speedometer.Stop();
            return chart;
        }

        public static double Derive(CompiledExpression compiledExpression, double x)
        {
            double x1 = x == 0 ? 0.0001 : x*(1 + 0.0001);
            double x2 = 2*x - x1;
            VariableValue variable1 = new VariableValue(x1, "x"), variable2 = new VariableValue(x2, "x");
            return (ToolsHelper.Calculator.Calculate(compiledExpression, variable1)
                    - ToolsHelper.Calculator.Calculate(compiledExpression, variable2))/(x1 - x2);
        }

        public static ObservableCollection<PointF> Newton(CompiledExpression compiledExpression)
        {
            var Chart = new ObservableCollection<PointF>();
            double x = 0.565;
            var variable = new VariableValue(x, "x");
            while (Math.Abs(ToolsHelper.Calculator.Calculate(compiledExpression, variable)) > 0)
            {
                x -= (ToolsHelper.Calculator.Calculate(compiledExpression, variable)/Derive(compiledExpression, x));
                variable = new VariableValue(x, "x");
                Chart.Add(new PointF
                {
                    X = (float) x,
                    Y = (float) ToolsHelper.Calculator.Calculate(compiledExpression, variable)
                });
            }
            return Chart;
        }
    }
}
namespace CourseWork
{
    partial class OptimizationForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbDichotomy = new System.Windows.Forms.RadioButton();
            this.rbFibonacci = new System.Windows.Forms.RadioButton();
            this.rbNewton = new System.Windows.Forms.RadioButton();
            this.rbGold = new System.Windows.Forms.RadioButton();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbFunc = new System.Windows.Forms.RichTextBox();
            this.nudLeftInterval = new System.Windows.Forms.NumericUpDown();
            this.nudRightInterval = new System.Windows.Forms.NumericUpDown();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.lblResultX = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.gbMethods = new System.Windows.Forms.GroupBox();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblLimits = new System.Windows.Forms.Label();
            this.lblResultY = new System.Windows.Forms.Label();
            this.tbAccuracy = new System.Windows.Forms.TextBox();
            this.pTools = new System.Windows.Forms.Panel();
            this.pZoom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightInterval)).BeginInit();
            this.gbMethods.SuspendLayout();
            this.pTools.SuspendLayout();
            this.pZoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic.Location = new System.Drawing.Point(12, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(465, 249);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            // 
            // btnSolve
            // 
            this.btnSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSolve.Location = new System.Drawing.Point(351, 62);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(114, 24);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Решить";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(483, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbDichotomy
            // 
            this.rbDichotomy.AutoSize = true;
            this.rbDichotomy.Location = new System.Drawing.Point(6, 14);
            this.rbDichotomy.Name = "rbDichotomy";
            this.rbDichotomy.Size = new System.Drawing.Size(82, 17);
            this.rbDichotomy.TabIndex = 3;
            this.rbDichotomy.Text = "Дихотомия";
            this.rbDichotomy.UseVisualStyleBackColor = true;
            // 
            // rbFibonacci
            // 
            this.rbFibonacci.AutoSize = true;
            this.rbFibonacci.Location = new System.Drawing.Point(123, 14);
            this.rbFibonacci.Name = "rbFibonacci";
            this.rbFibonacci.Size = new System.Drawing.Size(82, 17);
            this.rbFibonacci.TabIndex = 4;
            this.rbFibonacci.Text = "Фибоначчи";
            this.rbFibonacci.UseVisualStyleBackColor = true;
            // 
            // rbNewton
            // 
            this.rbNewton.AutoSize = true;
            this.rbNewton.Location = new System.Drawing.Point(123, 37);
            this.rbNewton.Name = "rbNewton";
            this.rbNewton.Size = new System.Drawing.Size(64, 17);
            this.rbNewton.TabIndex = 5;
            this.rbNewton.Text = "Ньютон";
            this.rbNewton.UseVisualStyleBackColor = true;
            // 
            // rbGold
            // 
            this.rbGold.AutoSize = true;
            this.rbGold.Location = new System.Drawing.Point(6, 37);
            this.rbGold.Name = "rbGold";
            this.rbGold.Size = new System.Drawing.Size(111, 17);
            this.rbGold.TabIndex = 6;
            this.rbGold.Text = "Золотое сечение";
            this.rbGold.UseVisualStyleBackColor = true;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dgvResult.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvResult.Location = new System.Drawing.Point(483, 12);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowHeadersWidth = 20;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(166, 311);
            this.dgvResult.TabIndex = 7;
            this.dgvResult.SelectionChanged += new System.EventHandler(this.dgvResult_SelectionChanged);
            // 
            // X
            // 
            this.X.FillWeight = 1F;
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 40;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.X.Width = 75;
            // 
            // F
            // 
            this.F.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.F.FillWeight = 20F;
            this.F.HeaderText = "F(X)";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rtbFunc
            // 
            this.rtbFunc.Location = new System.Drawing.Point(2, 7);
            this.rtbFunc.Name = "rtbFunc";
            this.rtbFunc.Size = new System.Drawing.Size(131, 53);
            this.rtbFunc.TabIndex = 8;
            this.rtbFunc.Text = "sin(x^2)";
            // 
            // nudLeftInterval
            // 
            this.nudLeftInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudLeftInterval.DecimalPlaces = 1;
            this.nudLeftInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudLeftInterval.Location = new System.Drawing.Point(209, 66);
            this.nudLeftInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudLeftInterval.Name = "nudLeftInterval";
            this.nudLeftInterval.Size = new System.Drawing.Size(65, 20);
            this.nudLeftInterval.TabIndex = 9;
            this.nudLeftInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudRightInterval
            // 
            this.nudRightInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudRightInterval.DecimalPlaces = 1;
            this.nudRightInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudRightInterval.Location = new System.Drawing.Point(280, 66);
            this.nudRightInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudRightInterval.Name = "nudRightInterval";
            this.nudRightInterval.Size = new System.Drawing.Size(65, 20);
            this.nudRightInterval.TabIndex = 10;
            this.nudRightInterval.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Enabled = false;
            this.btnZoomOut.Image = global::CourseWork.Properties.Resources.zoomout;
            this.btnZoomOut.Location = new System.Drawing.Point(29, 0);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 23);
            this.btnZoomOut.TabIndex = 11;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoonOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Enabled = false;
            this.btnZoomIn.Image = global::CourseWork.Properties.Resources.zoomin;
            this.btnZoomIn.Location = new System.Drawing.Point(0, 0);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 23);
            this.btnZoomIn.TabIndex = 12;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoonIn_Click);
            // 
            // lblResultX
            // 
            this.lblResultX.AutoSize = true;
            this.lblResultX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultX.Location = new System.Drawing.Point(354, 15);
            this.lblResultX.Name = "lblResultX";
            this.lblResultX.Size = new System.Drawing.Size(26, 18);
            this.lblResultX.TabIndex = 14;
            this.lblResultX.Text = "X: ";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(564, 329);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(85, 24);
            this.btnCopy.TabIndex = 15;
            this.btnCopy.Text = "Скопировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // gbMethods
            // 
            this.gbMethods.Controls.Add(this.rbDichotomy);
            this.gbMethods.Controls.Add(this.rbFibonacci);
            this.gbMethods.Controls.Add(this.rbNewton);
            this.gbMethods.Controls.Add(this.rbGold);
            this.gbMethods.Location = new System.Drawing.Point(140, 3);
            this.gbMethods.Name = "gbMethods";
            this.gbMethods.Size = new System.Drawing.Size(208, 57);
            this.gbMethods.TabIndex = 16;
            this.gbMethods.TabStop = false;
            this.gbMethods.Text = "Методы оптимизации";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Location = new System.Drawing.Point(0, 68);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(57, 13);
            this.lblAccuracy.TabIndex = 18;
            this.lblAccuracy.Text = "Точность:";
            // 
            // lblLimits
            // 
            this.lblLimits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLimits.AutoSize = true;
            this.lblLimits.Location = new System.Drawing.Point(136, 68);
            this.lblLimits.Name = "lblLimits";
            this.lblLimits.Size = new System.Drawing.Size(67, 13);
            this.lblLimits.TabIndex = 19;
            this.lblLimits.Text = "Интервалы:";
            // 
            // lblResultY
            // 
            this.lblResultY.AutoSize = true;
            this.lblResultY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultY.Location = new System.Drawing.Point(354, 38);
            this.lblResultY.Name = "lblResultY";
            this.lblResultY.Size = new System.Drawing.Size(25, 18);
            this.lblResultY.TabIndex = 20;
            this.lblResultY.Text = "Y: ";
            // 
            // tbAccuracy
            // 
            this.tbAccuracy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAccuracy.Location = new System.Drawing.Point(63, 65);
            this.tbAccuracy.Name = "tbAccuracy";
            this.tbAccuracy.Size = new System.Drawing.Size(70, 20);
            this.tbAccuracy.TabIndex = 21;
            this.tbAccuracy.Text = "0,0001";
            // 
            // pTools
            // 
            this.pTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pTools.Controls.Add(this.rtbFunc);
            this.pTools.Controls.Add(this.lblLimits);
            this.pTools.Controls.Add(this.lblResultY);
            this.pTools.Controls.Add(this.tbAccuracy);
            this.pTools.Controls.Add(this.lblAccuracy);
            this.pTools.Controls.Add(this.gbMethods);
            this.pTools.Controls.Add(this.btnSolve);
            this.pTools.Controls.Add(this.lblResultX);
            this.pTools.Controls.Add(this.nudLeftInterval);
            this.pTools.Controls.Add(this.nudRightInterval);
            this.pTools.Location = new System.Drawing.Point(12, 267);
            this.pTools.Name = "pTools";
            this.pTools.Size = new System.Drawing.Size(465, 86);
            this.pTools.TabIndex = 22;
            // 
            // pZoom
            // 
            this.pZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pZoom.BackColor = System.Drawing.Color.White;
            this.pZoom.Controls.Add(this.btnZoomIn);
            this.pZoom.Controls.Add(this.btnZoomOut);
            this.pZoom.Location = new System.Drawing.Point(421, 234);
            this.pZoom.Name = "pZoom";
            this.pZoom.Size = new System.Drawing.Size(52, 23);
            this.pZoom.TabIndex = 23;
            // 
            // OptimizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 365);
            this.Controls.Add(this.pZoom);
            this.Controls.Add(this.pTools);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pic);
            this.MinimumSize = new System.Drawing.Size(677, 404);
            this.Name = "OptimizationForm";
            this.Text = "Оптимизация - Михальченко Денис";
            this.Resize += new System.EventHandler(this.Optimization_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightInterval)).EndInit();
            this.gbMethods.ResumeLayout(false);
            this.gbMethods.PerformLayout();
            this.pTools.ResumeLayout(false);
            this.pTools.PerformLayout();
            this.pZoom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbDichotomy;
        private System.Windows.Forms.RadioButton rbFibonacci;
        private System.Windows.Forms.RadioButton rbNewton;
        private System.Windows.Forms.RadioButton rbGold;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.RichTextBox rtbFunc;
        private System.Windows.Forms.NumericUpDown nudLeftInterval;
        private System.Windows.Forms.NumericUpDown nudRightInterval;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Label lblResultX;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox gbMethods;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblLimits;
        private System.Windows.Forms.Label lblResultY;
        private System.Windows.Forms.TextBox tbAccuracy;
        private System.Windows.Forms.Panel pTools;
        private System.Windows.Forms.Panel pZoom;
    }
}


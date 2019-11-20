namespace Fractals
{
    partial class FractalsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.DY = new System.Windows.Forms.NumericUpDown();
            this.dYLabel = new System.Windows.Forms.Label();
            this.DX = new System.Windows.Forms.NumericUpDown();
            this.dXLabel = new System.Windows.Forms.Label();
            this.Scale = new System.Windows.Forms.NumericUpDown();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.BransleyFractal = new System.Windows.Forms.Button();
            this.PointCount = new System.Windows.Forms.NumericUpDown();
            this.PointCountLabel = new System.Windows.Forms.Label();
            this.FractalCoeff = new System.Windows.Forms.NumericUpDown();
            this.FractalCoeffLabel = new System.Windows.Forms.Label();
            this.BuildButton = new System.Windows.Forms.Button();
            this.SidesCount = new System.Windows.Forms.NumericUpDown();
            this.SideCountLabel = new System.Windows.Forms.Label();
            this.LineChecker = new System.Windows.Forms.CheckBox();
            this.KochFractal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SidesCount)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(613, 571);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.KochFractal);
            this.SettingsPanel.Controls.Add(this.LineChecker);
            this.SettingsPanel.Controls.Add(this.DY);
            this.SettingsPanel.Controls.Add(this.dYLabel);
            this.SettingsPanel.Controls.Add(this.DX);
            this.SettingsPanel.Controls.Add(this.dXLabel);
            this.SettingsPanel.Controls.Add(this.Scale);
            this.SettingsPanel.Controls.Add(this.ScaleLabel);
            this.SettingsPanel.Controls.Add(this.BransleyFractal);
            this.SettingsPanel.Controls.Add(this.PointCount);
            this.SettingsPanel.Controls.Add(this.PointCountLabel);
            this.SettingsPanel.Controls.Add(this.FractalCoeff);
            this.SettingsPanel.Controls.Add(this.FractalCoeffLabel);
            this.SettingsPanel.Controls.Add(this.BuildButton);
            this.SettingsPanel.Controls.Add(this.SidesCount);
            this.SettingsPanel.Controls.Add(this.SideCountLabel);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SettingsPanel.Location = new System.Drawing.Point(619, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(226, 571);
            this.SettingsPanel.TabIndex = 1;
            // 
            // DY
            // 
            this.DY.DecimalPlaces = 4;
            this.DY.Location = new System.Drawing.Point(94, 130);
            this.DY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.DY.Name = "DY";
            this.DY.Size = new System.Drawing.Size(120, 22);
            this.DY.TabIndex = 5;
            this.DY.ValueChanged += new System.EventHandler(this.DY_ValueChanged);
            // 
            // dYLabel
            // 
            this.dYLabel.AutoSize = true;
            this.dYLabel.Location = new System.Drawing.Point(2, 132);
            this.dYLabel.Name = "dYLabel";
            this.dYLabel.Size = new System.Drawing.Size(29, 17);
            this.dYLabel.TabIndex = 12;
            this.dYLabel.Text = "dY:";
            // 
            // DX
            // 
            this.DX.DecimalPlaces = 4;
            this.DX.Location = new System.Drawing.Point(94, 102);
            this.DX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.DX.Name = "DX";
            this.DX.Size = new System.Drawing.Size(120, 22);
            this.DX.TabIndex = 4;
            this.DX.ValueChanged += new System.EventHandler(this.DX_ValueChanged);
            // 
            // dXLabel
            // 
            this.dXLabel.AutoSize = true;
            this.dXLabel.Location = new System.Drawing.Point(2, 104);
            this.dXLabel.Name = "dXLabel";
            this.dXLabel.Size = new System.Drawing.Size(29, 17);
            this.dXLabel.TabIndex = 10;
            this.dXLabel.Text = "dX:";
            // 
            // Scale
            // 
            this.Scale.DecimalPlaces = 2;
            this.Scale.Location = new System.Drawing.Point(94, 10);
            this.Scale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Scale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(120, 22);
            this.Scale.TabIndex = 1;
            this.Scale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Scale.ValueChanged += new System.EventHandler(this.Scale_ValueChanged);
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Location = new System.Drawing.Point(2, 12);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(51, 17);
            this.ScaleLabel.TabIndex = 8;
            this.ScaleLabel.Text = "Scale: ";
            // 
            // BransleyFractal
            // 
            this.BransleyFractal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BransleyFractal.Location = new System.Drawing.Point(0, 485);
            this.BransleyFractal.Name = "BransleyFractal";
            this.BransleyFractal.Size = new System.Drawing.Size(226, 43);
            this.BransleyFractal.TabIndex = 7;
            this.BransleyFractal.Text = "Bransley Fractal";
            this.BransleyFractal.UseVisualStyleBackColor = true;
            this.BransleyFractal.Click += new System.EventHandler(this.BransleyFractal_Click);
            // 
            // PointCount
            // 
            this.PointCount.Location = new System.Drawing.Point(94, 42);
            this.PointCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.PointCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PointCount.Name = "PointCount";
            this.PointCount.Size = new System.Drawing.Size(120, 22);
            this.PointCount.TabIndex = 2;
            this.PointCount.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.PointCount.ValueChanged += new System.EventHandler(this.PointCount_ValueChanged);
            // 
            // PointCountLabel
            // 
            this.PointCountLabel.AutoSize = true;
            this.PointCountLabel.Location = new System.Drawing.Point(2, 44);
            this.PointCountLabel.Name = "PointCountLabel";
            this.PointCountLabel.Size = new System.Drawing.Size(87, 17);
            this.PointCountLabel.TabIndex = 5;
            this.PointCountLabel.Text = "Point count: ";
            // 
            // FractalCoeff
            // 
            this.FractalCoeff.DecimalPlaces = 4;
            this.FractalCoeff.Location = new System.Drawing.Point(94, 74);
            this.FractalCoeff.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FractalCoeff.Name = "FractalCoeff";
            this.FractalCoeff.Size = new System.Drawing.Size(120, 22);
            this.FractalCoeff.TabIndex = 3;
            this.FractalCoeff.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // FractalCoeffLabel
            // 
            this.FractalCoeffLabel.AutoSize = true;
            this.FractalCoeffLabel.Location = new System.Drawing.Point(2, 76);
            this.FractalCoeffLabel.Name = "FractalCoeffLabel";
            this.FractalCoeffLabel.Size = new System.Drawing.Size(90, 17);
            this.FractalCoeffLabel.TabIndex = 3;
            this.FractalCoeffLabel.Text = "Fractal coeff:";
            // 
            // BuildButton
            // 
            this.BuildButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BuildButton.Location = new System.Drawing.Point(0, 528);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(226, 43);
            this.BuildButton.TabIndex = 8;
            this.BuildButton.Text = "Build Fractal";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // SidesCount
            // 
            this.SidesCount.Location = new System.Drawing.Point(94, 185);
            this.SidesCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SidesCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.SidesCount.Name = "SidesCount";
            this.SidesCount.Size = new System.Drawing.Size(120, 22);
            this.SidesCount.TabIndex = 6;
            this.SidesCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.SidesCount.ValueChanged += new System.EventHandler(this.SidesCount_ValueChanged);
            // 
            // SideCountLabel
            // 
            this.SideCountLabel.AutoSize = true;
            this.SideCountLabel.Location = new System.Drawing.Point(2, 187);
            this.SideCountLabel.Name = "SideCountLabel";
            this.SideCountLabel.Size = new System.Drawing.Size(86, 17);
            this.SideCountLabel.TabIndex = 0;
            this.SideCountLabel.Text = "Sides count:";
            // 
            // LineChecker
            // 
            this.LineChecker.AutoSize = true;
            this.LineChecker.Location = new System.Drawing.Point(94, 158);
            this.LineChecker.Name = "LineChecker";
            this.LineChecker.Size = new System.Drawing.Size(59, 21);
            this.LineChecker.TabIndex = 13;
            this.LineChecker.Text = "lines";
            this.LineChecker.UseVisualStyleBackColor = true;
            this.LineChecker.CheckedChanged += new System.EventHandler(this.LineChecker_CheckedChanged);
            // 
            // KochFractal
            // 
            this.KochFractal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KochFractal.Location = new System.Drawing.Point(0, 442);
            this.KochFractal.Name = "KochFractal";
            this.KochFractal.Size = new System.Drawing.Size(226, 43);
            this.KochFractal.TabIndex = 14;
            this.KochFractal.Text = "Koch Fractal";
            this.KochFractal.UseVisualStyleBackColor = true;
            this.KochFractal.Click += new System.EventHandler(this.KochFractal_Click);
            // 
            // FractalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 571);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.Canvas);
            this.Name = "FractalsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FractalsForm";
            this.Load += new System.EventHandler(this.FractalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SidesCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.NumericUpDown SidesCount;
        private System.Windows.Forms.Label SideCountLabel;
        private System.Windows.Forms.NumericUpDown FractalCoeff;
        private System.Windows.Forms.Label FractalCoeffLabel;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.NumericUpDown PointCount;
        private System.Windows.Forms.Label PointCountLabel;
        private System.Windows.Forms.Button BransleyFractal;
        private System.Windows.Forms.NumericUpDown Scale;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.NumericUpDown DY;
        private System.Windows.Forms.Label dYLabel;
        private System.Windows.Forms.NumericUpDown DX;
        private System.Windows.Forms.Label dXLabel;
        private System.Windows.Forms.CheckBox LineChecker;
        private System.Windows.Forms.Button KochFractal;
    }
}


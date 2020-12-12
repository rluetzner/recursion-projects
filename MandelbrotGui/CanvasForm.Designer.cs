
namespace MandelbrotGui
{
    partial class CanvasForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numKochCurve = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.kochCurveTab = new System.Windows.Forms.TabPage();
            this.kochSnowflakeTab = new System.Windows.Forms.TabPage();
            this.numKochSnowflake = new System.Windows.Forms.NumericUpDown();
            this.kochHexagonTab = new System.Windows.Forms.TabPage();
            this.numKochHexagon = new System.Windows.Forms.NumericUpDown();
            this.kochSquareTab = new System.Windows.Forms.TabPage();
            this.numKochSquare = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numKochCurve)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.kochCurveTab.SuspendLayout();
            this.kochSnowflakeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKochSnowflake)).BeginInit();
            this.kochHexagonTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKochHexagon)).BeginInit();
            this.kochSquareTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKochSquare)).BeginInit();
            this.SuspendLayout();
            // 
            // numKochCurve
            // 
            this.numKochCurve.Location = new System.Drawing.Point(1768, 902);
            this.numKochCurve.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numKochCurve.Name = "numKochCurve";
            this.numKochCurve.Size = new System.Drawing.Size(120, 23);
            this.numKochCurve.TabIndex = 0;
            this.numKochCurve.ValueChanged += new System.EventHandler(this.numKochCurve_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.kochCurveTab);
            this.tabControl1.Controls.Add(this.kochSnowflakeTab);
            this.tabControl1.Controls.Add(this.kochHexagonTab);
            this.tabControl1.Controls.Add(this.kochSquareTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1904, 961);
            this.tabControl1.TabIndex = 1;
            // 
            // kochCurveTab
            // 
            this.kochCurveTab.Controls.Add(this.numKochCurve);
            this.kochCurveTab.Location = new System.Drawing.Point(4, 24);
            this.kochCurveTab.Name = "kochCurveTab";
            this.kochCurveTab.Padding = new System.Windows.Forms.Padding(3);
            this.kochCurveTab.Size = new System.Drawing.Size(1896, 933);
            this.kochCurveTab.TabIndex = 0;
            this.kochCurveTab.Text = "Koch Curve";
            this.kochCurveTab.UseVisualStyleBackColor = true;
            this.kochCurveTab.Paint += new System.Windows.Forms.PaintEventHandler(this.kochCurveTab_Paint);
            // 
            // kochSnowflakeTab
            // 
            this.kochSnowflakeTab.Controls.Add(this.numKochSnowflake);
            this.kochSnowflakeTab.Location = new System.Drawing.Point(4, 24);
            this.kochSnowflakeTab.Name = "kochSnowflakeTab";
            this.kochSnowflakeTab.Padding = new System.Windows.Forms.Padding(3);
            this.kochSnowflakeTab.Size = new System.Drawing.Size(1896, 933);
            this.kochSnowflakeTab.TabIndex = 1;
            this.kochSnowflakeTab.Text = "Koch Snowflake Tab";
            this.kochSnowflakeTab.UseVisualStyleBackColor = true;
            this.kochSnowflakeTab.Paint += new System.Windows.Forms.PaintEventHandler(this.kochSnowflakeTab_Paint);
            // 
            // numKochSnowflake
            // 
            this.numKochSnowflake.Location = new System.Drawing.Point(1768, 902);
            this.numKochSnowflake.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numKochSnowflake.Name = "numKochSnowflake";
            this.numKochSnowflake.Size = new System.Drawing.Size(120, 23);
            this.numKochSnowflake.TabIndex = 1;
            this.numKochSnowflake.ValueChanged += new System.EventHandler(this.numKochSnowflake_ValueChanged);
            // 
            // kochHexagonTab
            // 
            this.kochHexagonTab.Controls.Add(this.numKochHexagon);
            this.kochHexagonTab.Location = new System.Drawing.Point(4, 24);
            this.kochHexagonTab.Name = "kochHexagonTab";
            this.kochHexagonTab.Size = new System.Drawing.Size(1896, 933);
            this.kochHexagonTab.TabIndex = 2;
            this.kochHexagonTab.Text = "Koch Hexagon";
            this.kochHexagonTab.UseVisualStyleBackColor = true;
            this.kochHexagonTab.Paint += new System.Windows.Forms.PaintEventHandler(this.kochHexagonTab_Paint);
            // 
            // numKochHexagon
            // 
            this.numKochHexagon.Location = new System.Drawing.Point(1768, 902);
            this.numKochHexagon.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numKochHexagon.Name = "numKochHexagon";
            this.numKochHexagon.Size = new System.Drawing.Size(120, 23);
            this.numKochHexagon.TabIndex = 2;
            this.numKochHexagon.ValueChanged += new System.EventHandler(this.numKochHexagon_ValueChanged);
            // 
            // kochSquareTab
            // 
            this.kochSquareTab.Controls.Add(this.numKochSquare);
            this.kochSquareTab.Location = new System.Drawing.Point(4, 24);
            this.kochSquareTab.Name = "kochSquareTab";
            this.kochSquareTab.Size = new System.Drawing.Size(1896, 933);
            this.kochSquareTab.TabIndex = 3;
            this.kochSquareTab.Text = "Koch Square";
            this.kochSquareTab.UseVisualStyleBackColor = true;
            this.kochSquareTab.Paint += new System.Windows.Forms.PaintEventHandler(this.kochSquareTab_Paint);
            // 
            // numericUpDown1
            // 
            this.numKochSquare.Location = new System.Drawing.Point(1768, 902);
            this.numKochSquare.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numKochSquare.Name = "numericUpDown1";
            this.numKochSquare.Size = new System.Drawing.Size(120, 23);
            this.numKochSquare.TabIndex = 3;
            this.numKochSquare.ValueChanged += new System.EventHandler(this.numKochSquare_ValueChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numKochCurve)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.kochCurveTab.ResumeLayout(false);
            this.kochSnowflakeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numKochSnowflake)).EndInit();
            this.kochHexagonTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numKochHexagon)).EndInit();
            this.kochSquareTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numKochSquare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numKochCurve;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage kochCurveTab;
        private System.Windows.Forms.TabPage kochSnowflakeTab;
        private System.Windows.Forms.NumericUpDown numKochSnowflake;
        private System.Windows.Forms.TabPage kochHexagonTab;
        private System.Windows.Forms.NumericUpDown numKochHexagon;
        private System.Windows.Forms.TabPage kochSquareTab;
        private System.Windows.Forms.NumericUpDown numKochSquare;
    }
}


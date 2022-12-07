namespace MandelBrot
{
    partial class Form1
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
            this.mandelBrotCanvas = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.midXTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.midYTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scaleFactorTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maxIterationsTb = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoOverMandelbrotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mandelBrotCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mandelBrotCanvas
            // 
            this.mandelBrotCanvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mandelBrotCanvas.Location = new System.Drawing.Point(12, 26);
            this.mandelBrotCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mandelBrotCanvas.Name = "mandelBrotCanvas";
            this.mandelBrotCanvas.Size = new System.Drawing.Size(400, 400);
            this.mandelBrotCanvas.TabIndex = 0;
            this.mandelBrotCanvas.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 177);
            this.button1.TabIndex = 1;
            this.button1.Text = "Genereer Mandelbrot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Midden X";
            // 
            // midXTb
            // 
            this.midXTb.Location = new System.Drawing.Point(418, 43);
            this.midXTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.midXTb.Name = "midXTb";
            this.midXTb.Size = new System.Drawing.Size(181, 23);
            this.midXTb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Midden Y";
            // 
            // midYTb
            // 
            this.midYTb.Location = new System.Drawing.Point(418, 101);
            this.midYTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.midYTb.Name = "midYTb";
            this.midYTb.Size = new System.Drawing.Size(181, 23);
            this.midYTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Schaalfactor";
            // 
            // scaleFactorTb
            // 
            this.scaleFactorTb.Location = new System.Drawing.Point(418, 157);
            this.scaleFactorTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleFactorTb.Name = "scaleFactorTb";
            this.scaleFactorTb.Size = new System.Drawing.Size(181, 23);
            this.scaleFactorTb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Max Aantal";
            // 
            // maxIterationsTb
            // 
            this.maxIterationsTb.Location = new System.Drawing.Point(418, 211);
            this.maxIterationsTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxIterationsTb.Name = "maxIterationsTb";
            this.maxIterationsTb.Size = new System.Drawing.Size(181, 23);
            this.maxIterationsTb.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCurrentImageToolStripMenuItem,
            this.infoOverMandelbrotToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveCurrentImageToolStripMenuItem
            // 
            this.saveCurrentImageToolStripMenuItem.Name = "saveCurrentImageToolStripMenuItem";
            this.saveCurrentImageToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveCurrentImageToolStripMenuItem.Text = "Save Current Image";
            this.saveCurrentImageToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentImageToolStripMenuItem_Click);
            // 
            // infoOverMandelbrotToolStripMenuItem
            // 
            this.infoOverMandelbrotToolStripMenuItem.Name = "infoOverMandelbrotToolStripMenuItem";
            this.infoOverMandelbrotToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.infoOverMandelbrotToolStripMenuItem.Text = "Info over mandelbrot";
            this.infoOverMandelbrotToolStripMenuItem.Click += new System.EventHandler(this.infoOverMandelbrotToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 437);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxIterationsTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scaleFactorTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.midYTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.midXTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mandelBrotCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Genereer vandaag jouw fantastische mandelbrot";
            ((System.ComponentModel.ISupportInitialize)(this.mandelBrotCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox mandelBrotCanvas;
        private Button button1;
        private Label label1;
        private TextBox midXTb;
        private Label label2;
        private TextBox midYTb;
        private Label label3;
        private TextBox scaleFactorTb;
        private Label label4;
        private TextBox maxIterationsTb;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveCurrentImageToolStripMenuItem;
        private ToolStripMenuItem infoOverMandelbrotToolStripMenuItem;
    }
}
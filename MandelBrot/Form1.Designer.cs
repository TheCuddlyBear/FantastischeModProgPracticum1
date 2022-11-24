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
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mandelBrotCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // mandelBrotCanvas
            // 
            this.mandelBrotCanvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mandelBrotCanvas.Location = new System.Drawing.Point(2, 1);
            this.mandelBrotCanvas.Name = "mandelBrotCanvas";
            this.mandelBrotCanvas.Size = new System.Drawing.Size(832, 606);
            this.mandelBrotCanvas.TabIndex = 0;
            this.mandelBrotCanvas.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(849, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Genereer Mandelbrot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Midden X";
            // 
            // midXTb
            // 
            this.midXTb.Location = new System.Drawing.Point(849, 32);
            this.midXTb.Name = "midXTb";
            this.midXTb.Size = new System.Drawing.Size(206, 27);
            this.midXTb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(849, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Midden Y";
            // 
            // midYTb
            // 
            this.midYTb.Location = new System.Drawing.Point(849, 109);
            this.midYTb.Name = "midYTb";
            this.midYTb.Size = new System.Drawing.Size(206, 27);
            this.midYTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(849, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Schaalfactor";
            // 
            // scaleFactorTb
            // 
            this.scaleFactorTb.Location = new System.Drawing.Point(849, 184);
            this.scaleFactorTb.Name = "scaleFactorTb";
            this.scaleFactorTb.Size = new System.Drawing.Size(206, 27);
            this.scaleFactorTb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(849, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Max Aantal";
            // 
            // maxIterationsTb
            // 
            this.maxIterationsTb.Location = new System.Drawing.Point(849, 256);
            this.maxIterationsTb.Name = "maxIterationsTb";
            this.maxIterationsTb.Size = new System.Drawing.Size(206, 27);
            this.maxIterationsTb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(949, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 608);
            this.Controls.Add(this.label5);
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
            this.Name = "Form1";
            this.Text = "Genereer vandaag jouw fantastische mandelbrot";
            ((System.ComponentModel.ISupportInitialize)(this.mandelBrotCanvas)).EndInit();
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
        private Label label5;
    }
}
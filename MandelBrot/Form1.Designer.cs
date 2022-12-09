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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lightlabel = new System.Windows.Forms.Label();
            this.huelabel = new System.Windows.Forms.Label();
            this.satlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lightness = new System.Windows.Forms.TrackBar();
            this.saturation = new System.Windows.Forms.TrackBar();
            this.hue = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hue)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(408, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Genereer Mandelbrot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Midden X";
            // 
            // midXTb
            // 
            this.midXTb.Location = new System.Drawing.Point(421, 63);
            this.midXTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.midXTb.Name = "midXTb";
            this.midXTb.Size = new System.Drawing.Size(181, 23);
            this.midXTb.TabIndex = 4;
            this.midXTb.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Midden Y";
            // 
            // midYTb
            // 
            this.midYTb.Location = new System.Drawing.Point(421, 121);
            this.midYTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.midYTb.Name = "midYTb";
            this.midYTb.Size = new System.Drawing.Size(181, 23);
            this.midYTb.TabIndex = 6;
            this.midYTb.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Schaalfactor";
            // 
            // scaleFactorTb
            // 
            this.scaleFactorTb.Location = new System.Drawing.Point(423, 177);
            this.scaleFactorTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleFactorTb.Name = "scaleFactorTb";
            this.scaleFactorTb.Size = new System.Drawing.Size(181, 23);
            this.scaleFactorTb.TabIndex = 8;
            this.scaleFactorTb.Text = "0,01";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Max Aantal";
            // 
            // maxIterationsTb
            // 
            this.maxIterationsTb.Location = new System.Drawing.Point(424, 231);
            this.maxIterationsTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxIterationsTb.Name = "maxIterationsTb";
            this.maxIterationsTb.Size = new System.Drawing.Size(181, 23);
            this.maxIterationsTb.TabIndex = 10;
            this.maxIterationsTb.Text = "1000";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCurrentImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveCurrentImageToolStripMenuItem
            // 
            this.saveCurrentImageToolStripMenuItem.Name = "saveCurrentImageToolStripMenuItem";
            this.saveCurrentImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveCurrentImageToolStripMenuItem.Text = "Save Current Image";
            this.saveCurrentImageToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentImageToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(10, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 14;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 383);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(408, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "Voorbeelden";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(416, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 239);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instellingen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lightlabel);
            this.groupBox2.Controls.Add(this.huelabel);
            this.groupBox2.Controls.Add(this.satlabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lightness);
            this.groupBox2.Controls.Add(this.saturation);
            this.groupBox2.Controls.Add(this.hue);
            this.groupBox2.Location = new System.Drawing.Point(624, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 295);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kleurinstellingen";
            // 
            // lightlabel
            // 
            this.lightlabel.AutoSize = true;
            this.lightlabel.Location = new System.Drawing.Point(145, 18);
            this.lightlabel.Name = "lightlabel";
            this.lightlabel.Size = new System.Drawing.Size(25, 15);
            this.lightlabel.TabIndex = 8;
            this.lightlabel.Text = "100";
            // 
            // huelabel
            // 
            this.huelabel.AutoSize = true;
            this.huelabel.Location = new System.Drawing.Point(15, 18);
            this.huelabel.Name = "huelabel";
            this.huelabel.Size = new System.Drawing.Size(25, 15);
            this.huelabel.TabIndex = 7;
            this.huelabel.Text = "360";
            // 
            // satlabel
            // 
            this.satlabel.AutoSize = true;
            this.satlabel.Location = new System.Drawing.Point(85, 18);
            this.satlabel.Name = "satlabel";
            this.satlabel.Size = new System.Drawing.Size(19, 15);
            this.satlabel.TabIndex = 6;
            this.satlabel.Text = "60";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lightness";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Saturation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hue";
            // 
            // lightness
            // 
            this.lightness.Location = new System.Drawing.Point(142, 35);
            this.lightness.Maximum = 100;
            this.lightness.Minimum = 1;
            this.lightness.Name = "lightness";
            this.lightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.lightness.Size = new System.Drawing.Size(45, 232);
            this.lightness.TabIndex = 2;
            this.lightness.Value = 100;
            this.lightness.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lightness_MouseUp);
            // 
            // saturation
            // 
            this.saturation.Location = new System.Drawing.Point(78, 32);
            this.saturation.Maximum = 100;
            this.saturation.Minimum = 1;
            this.saturation.Name = "saturation";
            this.saturation.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.saturation.Size = new System.Drawing.Size(45, 235);
            this.saturation.TabIndex = 1;
            this.saturation.Value = 60;
            this.saturation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.saturation_MouseUp);
            // 
            // hue
            // 
            this.hue.Location = new System.Drawing.Point(15, 32);
            this.hue.Maximum = 360;
            this.hue.Minimum = 1;
            this.hue.Name = "hue";
            this.hue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.hue.Size = new System.Drawing.Size(45, 235);
            this.hue.TabIndex = 0;
            this.hue.Value = 360;
            this.hue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hue_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
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
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Genereer vandaag jouw fantastische mandelbrot";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Panel panel1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TrackBar lightness;
        private TrackBar saturation;
        private TrackBar hue;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lightlabel;
        private Label huelabel;
        private Label satlabel;
    }
}
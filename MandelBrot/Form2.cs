using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandelBrot
{
    public partial class Form2 : Form
    {

        public Form thisForm;
        public Form mainForm;
        public GroupBox groupBox;
        public Form2()
        {
            InitializeComponent();
            thisForm = this;
            mainForm = Application.OpenForms[0];
            groupBox = (GroupBox)mainForm.Controls["groupBox2"];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TextBox midXTb = (TextBox)mainForm.Controls["midXTb"];
            midXTb.Text = "0,0040685963";

            TextBox midYTb = (TextBox)mainForm.Controls["midYTb"];
            midYTb.Text = "0,8089094";

            TextBox scaleFactorTb = (TextBox)mainForm.Controls["scaleFactorTb"];
            scaleFactorTb.Text = "3,6893514E-08";

            TextBox maxIterationsTb = (TextBox)mainForm.Controls["maxIterationsTb"];
            maxIterationsTb.Text = "1000";

            TrackBar hue = (TrackBar)groupBox.Controls["hue"];
            hue.Value = 360;

            TrackBar sat = (TrackBar)groupBox.Controls["saturation"];
            sat.Value = 60;

            TrackBar light = (TrackBar)groupBox.Controls["lightness"];
            light.Value = 100;

            Button genButton = (Button)mainForm.Controls["button1"];
            genButton.PerformClick();


            thisForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox midXTb = (TextBox)mainForm.Controls["midXTb"];
            midXTb.Text = "-0,006875";

            TextBox midYTb = (TextBox)mainForm.Controls["midYTb"];
            midYTb.Text = "-0,80638671875";

            TextBox scaleFactorTb = (TextBox)mainForm.Controls["scaleFactorTb"];
            scaleFactorTb.Text = "9,765625E-06";

            TextBox maxIterationsTb = (TextBox)mainForm.Controls["maxIterationsTb"];
            maxIterationsTb.Text = "1000";

            TrackBar hue = (TrackBar)groupBox.Controls["hue"];
            hue.Value = 250;

            TrackBar sat = (TrackBar)groupBox.Controls["saturation"];
            sat.Value = 81;

            TrackBar light = (TrackBar)groupBox.Controls["lightness"];
            light.Value = 100;

            Button genButton = (Button)mainForm.Controls["button1"];
            genButton.PerformClick();

            thisForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            TextBox midXTb = (TextBox)mainForm.Controls["midXTb"];
            midXTb.Text = "0,0030880242";

            TextBox midYTb = (TextBox)mainForm.Controls["midYTb"];
            midYTb.Text = "0,8170546";

            TextBox scaleFactorTb = (TextBox)mainForm.Controls["scaleFactorTb"];
            scaleFactorTb.Text = "2,1990243E-07";

            TextBox maxIterationsTb = (TextBox)mainForm.Controls["maxIterationsTb"];
            maxIterationsTb.Text = "1000";

            TrackBar hue = (TrackBar)groupBox.Controls["hue"];
            hue.Value = 241;

            TrackBar sat = (TrackBar)groupBox.Controls["saturation"];
            sat.Value = 64;

            TrackBar light = (TrackBar)groupBox.Controls["lightness"];
            light.Value = 100;


            Button genButton = (Button)mainForm.Controls["button1"];
            genButton.PerformClick();

            thisForm.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBox midXTb = (TextBox)mainForm.Controls["midXTb"];
            midXTb.Text = "-1,626583";

            TextBox midYTb = (TextBox)mainForm.Controls["midYTb"];
            midYTb.Text = "0,00010901131";

            TextBox scaleFactorTb = (TextBox)mainForm.Controls["scaleFactorTb"];
            scaleFactorTb.Text = "5,902962E-05";

            TextBox maxIterationsTb = (TextBox)mainForm.Controls["maxIterationsTb"];
            maxIterationsTb.Text = "1000";

            TrackBar hue = (TrackBar)groupBox.Controls["hue"];
            hue.Value = 360;

            TrackBar sat = (TrackBar)groupBox.Controls["saturation"];
            sat.Value = 60;

            TrackBar light = (TrackBar)groupBox.Controls["lightness"];
            light.Value = 100;


            Button genButton = (Button)mainForm.Controls["button1"];
            genButton.PerformClick();

            thisForm.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox midXTb = (TextBox)mainForm.Controls["midXTb"];
            midXTb.Text = "-0,16070803";

            TextBox midYTb = (TextBox)mainForm.Controls["midYTb"];
            midYTb.Text = "1,037048";

            TextBox scaleFactorTb = (TextBox)mainForm.Controls["scaleFactorTb"];
            scaleFactorTb.Text = "2,596151E-06";

            TextBox maxIterationsTb = (TextBox)mainForm.Controls["maxIterationsTb"];
            maxIterationsTb.Text = "1000";

            TrackBar hue = (TrackBar)groupBox.Controls["hue"];
            hue.Value = 360;

            TrackBar sat = (TrackBar)groupBox.Controls["saturation"];
            sat.Value = 60;

            TrackBar light = (TrackBar)groupBox.Controls["lightness"];
            light.Value = 100;


            Button genButton = (Button)mainForm.Controls["button1"];
            genButton.PerformClick();

            thisForm.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextBox midXTb = (TextBox)mainForm.Controls["midXTb"];
            midXTb.Text = "0,4143958";

            TextBox midYTb = (TextBox)mainForm.Controls["midYTb"];
            midYTb.Text = "-0,33326638";

            TextBox scaleFactorTb = (TextBox)mainForm.Controls["scaleFactorTb"];
            scaleFactorTb.Text = "6,338259E-06";

            TextBox maxIterationsTb = (TextBox)mainForm.Controls["maxIterationsTb"];
            maxIterationsTb.Text = "1000";

            TrackBar hue = (TrackBar)groupBox.Controls["hue"];
            hue.Value = 65;

            TrackBar sat = (TrackBar)groupBox.Controls["saturation"];
            sat.Value = 65;

            TrackBar light = (TrackBar)groupBox.Controls["lightness"];
            light.Value = 100;


            Button genButton = (Button)mainForm.Controls["button1"];
            genButton.PerformClick();

            thisForm.Close();
        }
    }
}

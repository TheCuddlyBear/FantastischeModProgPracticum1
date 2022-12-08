using System;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace MandelBrot
{
    public partial class Form1 : Form
    {

        Form thisForm;

        private Color[] Colors = new Color[768];
        public Form1()
        {
            InitializeComponent();
            GenerateColors();
            float midX = float.Parse(midXTb.Text) * -1;
            float midY = float.Parse(midYTb.Text) * -1;
            float scaleFactor = float.Parse(scaleFactorTb.Text);
            int maxIterations = Convert.ToInt32(maxIterationsTb.Text);

            Bitmap bmp = GenMandelImage(panel1.Size, midX, midY, scaleFactor, maxIterations);

            panel1.BackgroundImage = bmp;


            thisForm = this;
        }

        private void GenerateColors()
        {
            for (int i = 0; i < 768; i++)
            {
                int colorValueR = 0;
                int colorValueG = 0;
                int colorValueB = 0;
                if (i >= 512)
                {
                    colorValueR = i - 512;
                    colorValueG = 255 - colorValueR;
                }
                else if (i >= 256)
                {
                    colorValueG = i - 256;
                    colorValueB = 255 - colorValueG;
                }
                else
                {
                    colorValueB = i;
                }
                Colors[i] = Color.FromArgb(100, colorValueR, colorValueG, colorValueB);
            }

        }

        public Color linearInterpolation(Color color1, Color color2, int ratio)
        {
            int R = color1.R + (color2.R - color1.R) * ratio;
            int G = color1.G + (color2.G - color1.G) * ratio;
            int B = color1.B + (color2.B - color1.B) * ratio;

            return Color.FromArgb(100, R, G, B);

        }

        public Bitmap GenMandelImage(Size size, float midX, float midY, float scaleFactor, int maxIterations)
        {
            //converting the width and height to floats
            float width = Convert.ToSingle(size.Width);
            float height = Convert.ToSingle(size.Height);

            // calculating the ranges
            float xRange = width * scaleFactor;
            float yRange = height * scaleFactor;

            // Calculating the minimum of x and y
            float minX = (midX - (xRange / 2));
            float maxX = ((xRange / 2) + midX);
            float minY = (midY - (yRange / 2));
            float maxY = ((yRange / 2) + midY);

            Bitmap mandelBitmap = new Bitmap(size.Width, size.Height);

            // checking each x and y in the bitmap and generating its color
            for(int pixelY = 0; pixelY < size.Height; pixelY++)
            {
                for(int pixelX = 0; pixelX < size.Width; pixelX++)
                {
                    int iteration = 0;
                    double x = minX + (maxX - minX) * pixelX / (size.Width);
                    double y = minY + (maxY - minY) * pixelY / (size.Height);

                    double a = x; double b = y;
                    do
                    {
                        (a, b) = (a * a - b * b + x, 2 * a * b + y); // tuple for generating a and b
                        iteration++;
                    } while (iteration <= maxIterations && a * a + b * b < 4);
                    if (iteration < maxIterations)
                    {
                        Complex zn = new Complex(a, b);
                        double colorAlgorithm = iteration + 1 - Math.Log(Math.Log(Complex.Abs(zn)) / Math.Log(2)) / Math.Log(2);
                        /*double colorIndex = (double)(colorAlgorithm / maxIterations * 750);

                        if (colorIndex >= 750) colorIndex = 750;
                        if (colorIndex < 0) colorIndex = 0;

                        Color color1 = Colors[(int)Math.Floor(colorIndex)];
                        Color color2 = Colors[(int)Math.Floor(colorIndex) + 1];

                        Color color = linearInterpolation(color1, color2, (int)(colorAlgorithm % 1));*/
                        // // Continuous Smooth coloring algorithm (see wikipedia)
                        Color color = Utils.ColorFromHSV(0.95 + 5 * colorAlgorithm, 0.6, 1.0); // Generating the color from HSV values
                        mandelBitmap.SetPixel(pixelX, pixelY, color);
                    }
                    else
                    {
                        mandelBitmap.SetPixel(pixelX, pixelY, Color.Black);
                    }
                }


            }

            return mandelBitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(midXTb.Text) || string.IsNullOrEmpty(midYTb.Text) | string.IsNullOrEmpty(maxIterationsTb.Text) || string.IsNullOrEmpty(scaleFactorTb.Text))
            {

                MessageBox.Show("Je hebt niet alle velden ingevuld!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else
            {
                float midX = float.Parse(midXTb.Text);
                float midY = float.Parse(midYTb.Text);
                float scaleFactor = float.Parse(scaleFactorTb.Text);
                int maxIterations = Convert.ToInt32(maxIterationsTb.Text);

                Properties.Settings.Default.midX = midX;
                Properties.Settings.Default.midY = midY;
                Properties.Settings.Default.scaleFactor = scaleFactor;
                Properties.Settings.Default.maxIter = maxIterations;

                Bitmap bmp = GenMandelImage(panel1.Size, midX, midY, scaleFactor, maxIterations);

                panel1.BackgroundImage = bmp;
            }
        }
        private void saveCurrentImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.SavePictureBoxImage(panel1); // See Utils class for the code
        }

        private void infoOverMandelbrotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "https://en.wikipedia.org/wiki/Plotting_algorithms_for_the_Mandelbrot_set";
            process.Start();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            float midX = string.IsNullOrEmpty(midXTb.Text) ? Properties.Settings.Default.midX : float.Parse(midXTb.Text);    
            float midY = string.IsNullOrEmpty(midYTb.Text) ? Properties.Settings.Default.midY : float.Parse(midYTb.Text);
            float pixelX = e.X;
            float pixelY = e.Y;


            if (e.Button == MouseButtons.Right) 
            {

                float oldScaleFactor = string.IsNullOrEmpty(scaleFactorTb.Text) ? Properties.Settings.Default.scaleFactor : float.Parse(scaleFactorTb.Text);
                float newScaleFactor = oldScaleFactor / 0.8f;

                float xRange = panel1.Width * newScaleFactor;
                float yRange = panel1.Height * newScaleFactor;

                float minX = (midX - (xRange / 2));
                float maxX = ((xRange / 2) + midX);
                float minY = (midY - (yRange / 2));
                float maxY = ((yRange / 2) + midY);

                float x = minX + (maxX - minX) * pixelX / (panel1.Width);
                float y = minY + (maxY - minY) * pixelY / (panel1.Height);

                midXTb.Text = x.ToString();
                midYTb.Text = y.ToString();
                scaleFactorTb.Text = newScaleFactor.ToString();

                int maxIter = string.IsNullOrEmpty(maxIterationsTb.Text) ? Properties.Settings.Default.maxIter : int.Parse(maxIterationsTb.Text);
                maxIterationsTb.Text = maxIter.ToString();

                Properties.Settings.Default.midX = x;
                Properties.Settings.Default.midY = y;
                Properties.Settings.Default.scaleFactor = newScaleFactor;
                Properties.Settings.Default.maxIter = maxIter;

                Bitmap bmp = GenMandelImage(panel1.Size, x, y, newScaleFactor, maxIter);

                panel1.BackgroundImage = bmp;
            }else if(e.Button == MouseButtons.Left)
            {
                float oldScaleFactor = string.IsNullOrEmpty(scaleFactorTb.Text) ? Properties.Settings.Default.scaleFactor : float.Parse(scaleFactorTb.Text);
                float newScaleFactor = oldScaleFactor * 0.8f;

                float xRange = panel1.Width * newScaleFactor;
                float yRange = panel1.Height * newScaleFactor;

                float minX = (midX - (xRange / 2));
                float maxX = ((xRange / 2) + midX);
                float minY = (midY - (yRange / 2));
                float maxY = ((yRange / 2) + midY);

                float x = minX + (maxX - minX) * pixelX / (panel1.Width);
                float y = minY + (maxY - minY) * pixelY / (panel1.Height);

                midXTb.Text = x.ToString();
                midYTb.Text = y.ToString();
                scaleFactorTb.Text = newScaleFactor.ToString();

                int maxIter = string.IsNullOrEmpty(maxIterationsTb.Text) ? Properties.Settings.Default.maxIter : int.Parse(maxIterationsTb.Text);
                maxIterationsTb.Text = maxIter.ToString();

                Properties.Settings.Default.midX = x;
                Properties.Settings.Default.midY = y;
                Properties.Settings.Default.scaleFactor = newScaleFactor;
                Properties.Settings.Default.maxIter = maxIter;

                Bitmap bmp = GenMandelImage(panel1.Size, x, y, newScaleFactor, maxIter);

                panel1.BackgroundImage = bmp;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }
    }
}
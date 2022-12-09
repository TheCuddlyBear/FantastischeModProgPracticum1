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
        public Form1()
        {
            InitializeComponent();

            float midX = float.Parse(midXTb.Text) * -1;
            float midY = float.Parse(midYTb.Text) * -1;
            float scaleFactor = float.Parse(scaleFactorTb.Text);
            int maxIterations = Convert.ToInt32(maxIterationsTb.Text);

            Bitmap bmp = GenMandelImage(panel1.Size, midX, midY, scaleFactor, maxIterations);

            panel1.BackgroundImage = bmp;

            thisForm = this;
        }

        // Textbox values

        public Bitmap GenMandelImage(Size size, float midX, float midY, float scaleFactor, int maxIterations)
        {
            //converting the width and height to floats
            float width = Convert.ToSingle(size.Width);
            float height = Convert.ToSingle(size.Height);

            // calculating the ranges
            float xRange = width * scaleFactor;
            float yRange = height * scaleFactor;

            // Calculating the minimum of x and y, which can never exceed the intervals [-2,1] and [-2, 2]
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
                        double colorAlgorithm = iteration + 1 - Math.Log(Math.Log(Complex.Abs(zn)) / Math.Log(2)) / Math.Log(2); // Continuous Smooth coloring algorithm (see wikipedia)
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
            float midX = float.Parse(midXTb.Text);
            float midY = float.Parse(midYTb.Text);
            float scaleFactor = float.Parse(scaleFactorTb.Text);
            int maxIterations = Convert.ToInt32(maxIterationsTb.Text);

            Bitmap bmp = GenMandelImage(panel1.Size, midX, midY, scaleFactor, maxIterations);

            panel1.BackgroundImage = bmp;

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

        private void superSecretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            float midX = float.Parse(midXTb.Text);
            float midY = float.Parse(midYTb.Text);
            float pixelX = e.X;
            float pixelY = e.Y;




            if (e.Button == MouseButtons.Right) 
            {

                float oldScaleFactor = float.Parse(scaleFactorTb.Text);
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

                Bitmap bmp = GenMandelImage(panel1.Size, x, y, newScaleFactor, int.Parse(maxIterationsTb.Text));

                panel1.BackgroundImage = bmp;
            }else if(e.Button == MouseButtons.Left)
            {
                float oldScaleFactor = float.Parse(scaleFactorTb.Text);
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

                Bitmap bmp = GenMandelImage(panel1.Size, x, y, newScaleFactor, int.Parse(maxIterationsTb.Text));

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
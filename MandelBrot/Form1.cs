using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;

namespace MandelBrot
{
    public partial class Form1 : Form
    {

        public TimeSpan duration;
        public DateTime start;

        public Form1()
        {
            InitializeComponent();
        }

        public Bitmap GenMandelImage(Size size, float midX, float midY, float scaleFactor, int maxIterations)
        {
            start = DateTime.Now;
            timer1.Start();
            float width = Convert.ToSingle(size.Width);
            float height = Convert.ToSingle(size.Height);

            float xRange = width * scaleFactor;
            float yRange = height * scaleFactor;

            float minX = (midX - (xRange / 2)) < -2 ? -2 : midX - (xRange / 2);
            float maxX = ((xRange / 2) + midX) > 1 ? 1 : (xRange / 2) + midX;
            float minY = (midY - (yRange / 2)) < -2 ? -2 : midY - (yRange / 2);
            float maxY = ((yRange / 2) + midY) > 2 ? 2 : (yRange / 2) + midY;


            Bitmap mandelBitmap = new Bitmap(size.Width, size.Height);
            for(int dy = 0; dy < size.Height; dy++)
            {
                for(int dx = 0; dx < size.Width; dx++)
                {
                    double x = minX + (maxX - minX) * dx / (size.Width - 1);
                    double y = minY + (maxY - minY) * dy / (size.Height - 1);

                    double a = x; double b = y;
                    int iteration = 0;
                    do
                    {
                        (a, b) = (a * a - b * b + x, 2 * a * b + y);
                        iteration++;
                    } while (iteration <= maxIterations && a * a + b * b < 4);
                    if (iteration > maxIterations)
                    {
                        mandelBitmap.SetPixel(dx, dy, Color.Black);
                    }
                    else
                    {
                        Complex zn = new Complex(a, b);
                        double colorAlgorithm = iteration + 1 - Math.Log(Math.Log(Complex.Abs(zn)))/Math.Log(2);
                        Color color = Utils.ColorFromHSV(0.95 + 10 * colorAlgorithm, 0.6, 1.0);
                        mandelBitmap.SetPixel(dx, dy, color);
                    }

                }


            }
            timer1.Stop();
            statusLabel.Text = $"Time taken to generate: {duration.TotalMilliseconds} ms";
            return mandelBitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Generating image...";
            float midX = float.Parse(midXTb.Text);
            float midY = float.Parse(midYTb.Text);
            float scaleFactor = float.Parse(scaleFactorTb.Text);
            int maxIterations = Convert.ToInt32(maxIterationsTb.Text);

            Bitmap bmp = GenMandelImage(mandelBrotCanvas.Size, midX, midY, scaleFactor, maxIterations);

            mandelBrotCanvas.Image = bmp;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            duration = DateTime.Now - start;
        }

        private void saveCurrentImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.SavePictureBoxImage(mandelBrotCanvas);
        }

        private void infoOverMandelbrotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "https://en.wikipedia.org/wiki/Plotting_algorithms_for_the_Mandelbrot_set";
            process.Start();
        }
    }
}
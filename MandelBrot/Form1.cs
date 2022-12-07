using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;

namespace MandelBrot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color[] colors =
        {
            Color.FromArgb(255, 0, 0),
            Color.FromArgb(0, 255, 0),
            Color.FromArgb(0, 0, 255)
        };

        public Color LinearInterpolation(Color color1, Color color2, int ratio) {
            int r = Convert.ToInt32(Math.Floor(Convert.ToDouble((color2.R - color1.R) * ratio + color1.R)));
            int g = Convert.ToInt32(Math.Floor(Convert.ToDouble((color2.G - color1.G) * ratio + color1.G)));
            int b = Convert.ToInt32(Math.Floor(Convert.ToDouble((color2.B - color1.B) * ratio + color1.B)));
            return Color.FromArgb(r, g, b);
        }

        public Bitmap GenMandelImage(Size size, float midX, float midY, float scaleFactor, int maxIterations)
        {
            //converting the width and height to floats
            float width = Convert.ToSingle(size.Width);
            float height = Convert.ToSingle(size.Height);

            // calculating the ranges
            float xRange = width * scaleFactor;
            float yRange = height * scaleFactor;

            // Calculating the minimum of x and y, which can never exceed the intervals [-2,1] and [-2, 2]
            float minX = (midX - (xRange / 2)) < -2 ? -2 : midX - (xRange / 2);
            float maxX = ((xRange / 2) + midX) > 1 ? 1 : (xRange / 2) + midX;
            float minY = (midY - (yRange / 2)) < -2 ? -2 : midY - (yRange / 2);
            float maxY = ((yRange / 2) + midY) > 2 ? 2 : (yRange / 2) + midY;

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
                        double colorAlgorithm = iteration + 1 - Math.Log(Math.Log(Complex.Abs(zn))) / Math.Log(2); // Continuous Smooth coloring algorithm (see wikipedia)
                        Color color1 = colors[Convert.ToInt32(Math.Floor(colorAlgorithm))];
                        Color color2 = colors[Convert.ToInt32(Math.Floor(colorAlgorithm) + 1)];
                        //Color color = Utils.ColorFromHSV(0.95 + 5 * colorAlgorithm, 0.6, 1.0); // Generating the color from HSV values
                        Color color = LinearInterpolation(color1, color2, iteration % 1);
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
            float midX = float.Parse(midXTb.Text) * -1;
            float midY = float.Parse(midYTb.Text) * -1;
            float scaleFactor = float.Parse(scaleFactorTb.Text);
            int maxIterations = Convert.ToInt32(maxIterationsTb.Text);

            Bitmap bmp = GenMandelImage(mandelBrotCanvas.Size, midX, midY, scaleFactor, maxIterations);

            mandelBrotCanvas.Image = bmp;

        }
        private void saveCurrentImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.SavePictureBoxImage(mandelBrotCanvas); // See Utils class for the code
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
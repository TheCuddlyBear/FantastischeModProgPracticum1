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

        /*
        private PointF genMandelPunt(float a, float b, float x, float y)
        {
            return new PointF((a * a - b * b + x), (2 * a * b + y));
        }

        private int genMandelNumber(int maxIterations, float x, float y)
        {
            float a = 0f;
            float b = 0f;
            int count = 0;
            PointF startingPoint = new PointF(x, y);
            double distanceToPoint = 0;
            do
            {
                PointF mandelPunt = genMandelPunt(a, b, x, y);
                Debug.Print("Mandelpunt" + mandelPunt.ToString());
                distanceToPoint = Distance(mandelPunt, startingPoint);
                a = a + mandelPunt.X;
                b = b + mandelPunt.Y;
                Debug.Print("A: " + a.ToString());
                Debug.Print("B: " + b.ToString());
                count++;
                Debug.Print("Afstand: " + distanceToPoint.ToString());
                Debug.Print("Count: " + count.ToString());
            } while (count < maxIterations && distanceToPoint < 2);
                return count;
        }
        

        private double Distance(PointF p1, PointF p2)
        {
            double p1X = Convert.ToDouble(p1.X);
            double p1Y = Convert.ToDouble(p1.Y);
            double p2X = Convert.ToDouble(p2.X);
            double p2Y = Convert.ToDouble(p2.Y);
            double dX = Math.Pow((p1X - p2X), 2);
            double dY = Math.Pow((p1Y - p2Y), 2);
            return Math.Sqrt(dX + dY);
        }
        */

        public Color GetColor(int iterations, int maxIterations)
        {
            //TODO: Color

            return Color.Black;
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


            Bitmap bmp = new Bitmap(size.Width, size.Height);
            for(int dy = 0; dy < size.Height; dy++)
            {
                for(int dx = 0; dx < size.Width; dx++)
                {
                    double x = minX + ((maxX - minX) * dx) / (size.Width - 1);
                    double y = minY + ((maxY - minY) * dy) / (size.Height - 1);

                    double a = x; double b = y;
                    int iteration = 0;
                    do
                    {
                        // use tuples for iteration
                        (a, b) = (a * a - b * b + x, 2 * a * b + y);
                        iteration++;
                    } while (iteration <= maxIterations && a * a + b * b < 4);
                    if (iteration > maxIterations)
                    {
                        // interior color
                        bmp.SetPixel(dx, dy, Color.Black);
                    }
                    else
                    {
                        Color color = iteration % 2 == 0 ? Color.Yellow : Color.Green;
                        bmp.SetPixel(dx, dy, color);
                    }

                }


            }
            timer1.Stop();
            statusLabel.Text = $"Time taken to generate: {duration.TotalMilliseconds} ms";
            return bmp;
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
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    mandelBrotCanvas.Image.Save(saveFileDialog.FileName);
                }
            }
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
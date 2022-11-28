using System.Diagnostics;

namespace MandelBrot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
                Debug.Print("Distance: " + distanceToPoint.ToString());
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

        private Bitmap genImage(Size size, float minX, float maxX, float minY, float maxY, int maxIterations)
        {
            var mandelbrotBitmap = new Bitmap(size.Width, size.Height);
            for (int dy = 0; dy < size.Height; dy++)
            {
                for (int dx = 0; dx < size.Width; dx++)
                {
                    float x = minX + ((maxX - minX) * dx) / (size.Width - 1);
                    float y = minY + ((maxY - minY) * dy) / (size.Width - 1);

                    int mandelGetal = genMandelNumber(maxIterations, x, y);

                    if (mandelGetal % 2 == 0)
                    {
                        mandelbrotBitmap.SetPixel(dx, dy, Color.Black);
                    }
                    else
                    {
                        mandelbrotBitmap.SetPixel(dx, dy, Color.White);
                    }

                }
            }

            return mandelbrotBitmap;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            float midX = float.Parse(midXTb.Text);
            float midY = float.Parse(midYTb.Text);
            float scaleFactor = float.Parse(scaleFactorTb.Text);
            int maxIterations = Convert.ToInt32(maxIterationsTb.Text);

            float xRange = mandelBrotCanvas.Width * scaleFactor;
            float yRange = mandelBrotCanvas.Height * scaleFactor;

            float minX = 0 - (xRange / 2);
            float maxX = (xRange / 2) + 0;
            float minY = 0 - (yRange / 2);
            float maxY = (yRange / 2) + 0;

        }
    }
}
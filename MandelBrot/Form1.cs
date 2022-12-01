using System.Diagnostics;
using System.Numerics;

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

       public Color GenRandomColor()
        {
            Random random = new Random();
            int i = random.Next(1, 5);

            switch (i)
            {
                case 1:
                    return Color.FromArgb(76, 59, 77);
                case 2:
                    return Color.FromArgb(255, 238, 219);
                case 3:
                    return Color.FromArgb(173, 168, 182);
                case 4:
                    return Color.FromArgb(165, 56, 96);
                case 5:
                    return Color.FromArgb(97, 201, 168);
            }
            return Color.FromArgb(76, 59, 77);
        }

        private Color getColor(double i, double iterations)
        {
            double ratio = i / (double)(iterations);
            int col = (int)(i / iterations * 255);
            int alpha = 255;

            if (ratio >= 0 && ratio < 0.25)
                return Color.FromArgb(alpha, col, col / 5, 0);

            if (ratio >= 0.25 && ratio < 0.50)
                return Color.FromArgb(alpha, col, col / 4, 0);

            if (ratio >= 0.50 && ratio < 0.75)
                return Color.FromArgb(alpha, col, col / 3, 0);

            if (ratio >= 0.75 && ratio < 1)
                return Color.FromArgb(alpha, col, col / 2, 0);

            return Color.Black; //color of the set itself
        }

        public Bitmap GenMandelImage(Size size, float midX, float midY, float scaleFactor, int maxIterations)
        {
            float width = Convert.ToSingle(size.Width);
            float height = Convert.ToSingle(size.Height);

            float xRange = width * scaleFactor;
            float yRange = height * scaleFactor;

            Debug.WriteLine(xRange);
            Debug.WriteLine(yRange);

            float minX = midX - (xRange / 2);
            float maxX = (xRange / 2) + midX;
            float minY = midY - (yRange / 2);
            float maxY = (yRange / 2) + midY;


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
                        Color color = getColor(1, iteration);
                        bmp.SetPixel(dx, dy, color);
                    }

                }


            }
            return bmp;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            float midX = float.Parse(midXTb.Text);
            float midY = float.Parse(midYTb.Text);
            float scaleFactor = float.Parse(scaleFactorTb.Text);
            int maxIterations = Convert.ToInt32(maxIterationsTb.Text);

            Bitmap bmp = GenMandelImage(mandelBrotCanvas.Size, midX, midY, scaleFactor, maxIterations);

            mandelBrotCanvas.Image = bmp;

        }
    }
}
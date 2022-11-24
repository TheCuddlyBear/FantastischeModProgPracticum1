namespace MandelBrot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Point genMandelNumber(int a, int b, int x, int y)
        {
            return new Point((a * a - b * b + x), (2 * a * b + y));
        }

        private double distance(PointF p1, PointF p2)
        {
            double p1X = Convert.ToDouble(p1.X);
            double p1Y = Convert.ToDouble(p1.Y);
            double p2X = Convert.ToDouble(p2.X);
            double p2Y = Convert.ToDouble(p2.Y);
            double dX = Math.Pow((p1X - p2X), 2);
            double dY = Math.Pow((p1Y - p2Y), 2); 
            return Math.Sqrt(dX + dY);
        }

        private void genImage()
        {
            int midX = Convert.ToInt32(midXTb.Text);
            int midY = Convert.ToInt32(midYTb.Text);
            int scaleFactor = Convert.ToInt32(scaleFactorTb.Text);
            int maxIterations = Convert.ToInt32(maxIterationsTb.Text);

            int xRange = mandelBrotCanvas.Width * scaleFactor;
            int yRange = mandelBrotCanvas.Height * scaleFactor;

            int minX = 0 - (xRange / 2);
            int maxX = xRange / 2;
            int minY = 0 - (yRange / 2);
            int maxY = yRange / 2;




        }

        private void button1_Click(object sender, EventArgs e)
        
        }
    }
}
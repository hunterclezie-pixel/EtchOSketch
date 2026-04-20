/* 
Hunter Clezie 
Spring 2026
RCET2265
CarRental
github url: https://github.com/hunterclezie-pixel/CarRental.git
*/
namespace EtchOSketch
{
    public partial class EtchOSketchForm : Form
    {
        public EtchOSketchForm()
        {
            InitializeComponent();
        }

        //Global Variables below here --------------------------------------------------------------

        private int oldX, oldY;
        private Color penColor = Color.Black;
        private Color backColor = Color.White;
        private int penSize = 1;

        //Custom Methids below here --------------------------------------------------------------

        void DrawLineSegment(int newX, int newY)
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(this.penColor);
            thePen.Width = penSize;
            //draw the line here
            g.DrawLine(thePen, oldX, oldY, newX, newY);

            //free up resorces
            g.Dispose();
            thePen.Dispose();
        }

        void DrawSineWave()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.Lime);
            int lastX = 0, lastY = 0, currentY = 0;
            float scaleX = DisplayPictureBox.Width / 360f;
            float scaleY = (DisplayPictureBox.Height / 200f) * -1;

            g.TranslateTransform(0, DisplayPictureBox.Height / 2);

            g.ScaleTransform(scaleX, scaleY);

            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Sin((Math.PI / 180) * currentX)));
                g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;
            }

            //free up resorces
            g.Dispose();
            thePen.Dispose();
        }

        //Event Handlers below here --------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayPictureBox.Refresh();
        }
    }
}

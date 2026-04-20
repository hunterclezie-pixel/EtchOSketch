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

        //Event Handlers below here --------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

/* 
Hunter Clezie 
Spring 2026
RCET2265
EtchOSketch
github url: https://github.com/hunterclezie-pixel/EtchOSketch.git
*/
namespace EtchOSketch
{
    public partial class EtchOSketchForm : Form
    {
        public EtchOSketchForm()
        {
            InitializeComponent();
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseStuff;
            DisplayPictureBox.MouseDown += DisplayPictureBox_MouseStuff;

            // Event handlers for context menu items
            ExitStripMenuItem.Click += ExitButton_Click;
            ClearStripMenuItem.Click += ClearButton_Click;
            DrawWaveformStripMenuItem.Click += DrawWavefomButton_Click;
            SelectColorStripMenuItem.Click += SelectColorButton_Click;
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

        void DrawGrid()
        {
            int xDiv = DisplayPictureBox.Width / 10;
            int yDiv = DisplayPictureBox.Height / 8;

            this.oldX = 0;
            this.oldY = 0;
            for (int x = 0; x < DisplayPictureBox.Width; x += xDiv)
            {
                oldX = x;
                DrawLineSegment(x, DisplayPictureBox.Height);
            }

            this.oldX = 0;
            this.oldY = 0;
            for (int y = 0; y < DisplayPictureBox.Height; y += yDiv)
            {
                oldY = y;
                DrawLineSegment(DisplayPictureBox.Width, y);
            }
        }

        private void ShakeEtchOSketch()
        {
            Random random = new Random();
            int shakeAmount = 15; // Adjust this value to increase/decrease the shake intensity
            int originalX = this.Location.X;
            int originalY = this.Location.Y;

            for (int i = 0; i < 10; i++)
            {
                int offsetX = random.Next(-shakeAmount, shakeAmount + 1);
                int offsetY = random.Next(-shakeAmount, shakeAmount + 1);
                System.Threading.Thread.Sleep(50);
                this.Location = new Point(originalX + offsetX, originalY + offsetY);
            }
            this.Location = new Point(originalX, originalY); // Return to original position after shaking
        }

        private void DisplayPictureBox_MouseStuff(object? sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawLineSegment(e.X, e.Y);
                    break;
                case MouseButtons.Right:
                    DisplayContextMenuStrip.Show(DisplayPictureBox, e.Location);
                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }

            //Update last position on every move
            this.oldX = e.X;
            this.oldY = e.Y;
            this.Text = $"{e.X},{e.Y}";
        }

        private void UpdatePenColor()
        {
            PenColorDialog.ShowDialog();
            this.penColor = PenColorDialog.Color;
        }

        //Event Handlers below here --------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayPictureBox.Refresh();
            DisplayPictureBox.BackColor = Color.White;
            ShakeEtchOSketch();
        }

        private void DrawWavefomButton_Click(object sender, EventArgs e)
        {
            DisplayPictureBox.Refresh();
            DrawSineWave();
            DrawGrid();
        }

        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            UpdatePenColor();
        }

        private void AboutStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an EtchOSketch application, with basic drawing functionalities. \n" +
                "You can draw lines, select colors, and clear the screen. \n" +
                "This also allows a Sine, Cosine, and Tangent waves are drawn in different colors.");
        }
    }
}

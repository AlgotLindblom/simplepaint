using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplepaint
{
    public partial class Form1 : Form
    {

        public Composer c = new Composer();

        public Form1()
        {
            InitializeComponent();
            c.InitializeDrawingSurface();
            widthSelectionBar.Value = 4;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rityta_MouseDown(object sender, MouseEventArgs e)
        {
            c.Down(e);
        }

        private void rityta_MouseMove(object sender, MouseEventArgs e)
        {
            c.Draw(rityta, e);
        }

        private void rityta_MouseUp(object sender, MouseEventArgs e)
        {
            c.Up();         // Användaren har slutat rita och släppt musknappen
        }

        private void rityta_Paint(object sender, PaintEventArgs e)
        {
            c.PaintEvent(e);    //Egentligen rätt onödig
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            c.InitializeDrawingSurface();
            rityta.Invalidate();    //Återställ rityta vid klick på logo
        }
        

        private void widthSelectionBar_ValueChanged(object sender, EventArgs e)
        {
            c.SetWidth(widthSelectionBar.Value);    // Enkel väljare för tjpocklek
        }

        private void pBoxColorDialog_Click(object sender, EventArgs e)
        {
            c.SetColor(pBoxColorDialog);
        }
    }
    public class Composer
    {
        private bool isDrawing = false;     // En flagga som indikerar om användaren är i färd med att rita eller inte.
        private Point previousPoint;        // Håller koll på den tidigare muspositionen för att rita linjer.
        // private Color colorChoice;   Onödig med ColorDialog
        private float width;
        private ColorDialog colorPicker = new ColorDialog();

        // Deklarera en bitmap för att lagra ritområdet
        private Bitmap drawingSurface = new Bitmap(800, 600);

        public Composer()
        {
            colorPicker.Color = Color.Black;
            width = 4;
        }
        public void InitializeDrawingSurface()
        {
            using (Graphics g = Graphics.FromImage(drawingSurface))
            {
                g.Clear(Color.White);
            }
        }
        public void Up()
        {
            isDrawing = false;
        }
        public void Down(MouseEventArgs e)
        {
            isDrawing = true;                   // Användaren har börjat rita                
            previousPoint = e.Location;         // Sparar positionen där muspekaren befann sig när ritningen påbörjades i previousPoint
        }
        public void Draw(PictureBox rityta, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(drawingSurface))
                {
                    // Skapa en penna med svart färg och tjocklek 4
                    Pen pen = new Pen(colorPicker.Color, width);

                    // Rita en linje från föregående musposition till nuvarande musposition med den svarta pennan
                    g.DrawLine(pen, previousPoint, e.Location);
                    g.DrawRectangle(pen, new Rectangle(e.Location.X, e.Location.Y, (int)width, (int)width));
                }
                previousPoint = e.Location;

                // Uppdatera PictureBox för att visa de ändringar som gjorts på ritområdet
                rityta.Invalidate();
            }
        }
        public void PaintEvent(PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawingSurface, Point.Empty);  // Rita till ritytan när PaintEvent kallas
        }
        public void SetColor(PictureBox item) 
        {
            if(colorPicker.ShowDialog() == DialogResult.OK)
            {
                item.BackColor = colorPicker.Color;
            }
        }
        public void SetWidth(float val)
        {
            width = val;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplepaint
{
    public class Composer
    {
        private bool isDrawing = false;     // En flagga som indikerar om användaren är i färd med att rita eller inte.
        private Point previousPoint;        // Håller koll på den tidigare muspositionen för att rita linjer.
        // private Color colorChoice;   Onödig med ColorDialog
        private float width;
        private ColorDialog colorPicker = new ColorDialog();

        // Deklarera en bitmap för att lagra ritområdet
        public Bitmap drawingSurface = new Bitmap(800, 600);
        

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

        public void Up_IfLine()
        {
            isDrawing = false;
        }

        public void Down_IfLine(MouseEventArgs e)
        {
            isDrawing = true;                   // Användaren har börjat rita                
            previousPoint = e.Location;         // Sparar positionen där muspekaren befann sig när ritningen påbörjades i previousPoint
        }

        public void Move_IfLine(PictureBox rityta, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(drawingSurface))
                {
                    Pen pen = new Pen(colorPicker.Color, width);
                    
                    g.DrawLine(pen, previousPoint, e.Location);
                }
                previousPoint = e.Location;

                // Uppdatera PictureBox för att visa de ändringar som gjorts på ritområdet
                rityta.Invalidate();
            }
        }

        public void Down_IfRectangle(MouseEventArgs e)
        {
            isDrawing = false;
            previousPoint = e.Location;
        }

        public void Up_IfRectangle(PictureBox rityta, MouseEventArgs e)
        {
            // Av någon anledning fungerar enbart DrawRectangle om Rectangle har positiv height och width.
            // Detta krävs inte för DrawEllipse.
            Point currentPoint = e.Location;
            using (Graphics g = Graphics.FromImage(drawingSurface))
            {
                Pen pen = new Pen(colorPicker.Color, width);
                int x = Math.Min(previousPoint.X, currentPoint.X);
                int y = Math.Min(previousPoint.Y, currentPoint.Y);
                int w = Math.Abs(currentPoint.X - previousPoint.X);
                int h = Math.Abs(currentPoint.Y - previousPoint.Y);
                g.DrawRectangle(pen, new Rectangle(x, y, w, h));
            }
            rityta.Invalidate();
        }

        public void Down_IfEllipse(MouseEventArgs e)
        {
            isDrawing = false;
            previousPoint = e.Location;
        }

        public void Up_IfEllipse(PictureBox rityta, MouseEventArgs e)
        {
            using (Graphics g = Graphics.FromImage(drawingSurface))
            {
                Pen pen = new Pen(colorPicker.Color, width);
                g.DrawEllipse(pen, new Rectangle(previousPoint.X, previousPoint.Y, (e.Location.X - previousPoint.X), (e.Location.Y - previousPoint.Y)));
            }
            rityta.Invalidate();
        }

        public void PaintEvent(PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawingSurface, Point.Empty);  // Rita till ritytan när PaintEvent kallas
        }

        public void SetColor(PictureBox item)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                item.BackColor = colorPicker.Color;
            }
        }

        public void SetWidth(float val)
        {
            width = val;
        }

        public void Save()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG files (*.png)|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Spara bilden på den valda sökvägen som PNG
                drawingSurface.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
        }
    }
}

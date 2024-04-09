using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static simplepaint.Composer;

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
            shapeChoiceBox.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void rityta_MouseDown(object sender, MouseEventArgs e)
        {
            switch (shapeChoiceBox.SelectedIndex)
            {
                case 0:
                    c.Down_IfLine(e);
                    break;
                case 1:
                    c.Down_IfRectangle(e);
                    break;
                case 2:
                    c.Down_IfEllipse(e);
                    break;
            }
            
        }

        private void rityta_MouseMove(object sender, MouseEventArgs e)
        {
            if(shapeChoiceBox.SelectedIndex == 0)
            { 
                c.Draw_IfLine(rityta, e); 
            }
        }

        private void rityta_MouseUp(object sender, MouseEventArgs e)
        {
            // Användaren har slutat rita och släppt musknappen
            switch (shapeChoiceBox.SelectedIndex)
            {
                case 0:
                    c.Up_IfLine();
                    break;
                case 1:
                    c.Up_IfRectangle(rityta, e);
                    break;
                case 2:
                    c.Up_IfEllipse(rityta, e);
                    break;
            }
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
            c.SetWidth(widthSelectionBar.Value);    // Enkel väljare för tjocklek
        }

        private void pBoxColorDialog_Click(object sender, EventArgs e)
        {
            c.SetColor(pBoxColorDialog);
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shapeChoiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                     
        }
    }
}

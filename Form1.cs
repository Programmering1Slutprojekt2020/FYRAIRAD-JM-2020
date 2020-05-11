using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fyra_i_rad
{
    public partial class Form1 : Form
    {
        
        int s = 0;
        int s2 = 0;
        int klocka = 0;
        int[] fältx = new int[100];
        int[] fälty = new int[100];
        int[] fältx2 = new int[100];
        int[] fälty2 = new int[100];

        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush bl = new SolidBrush(Color.Black);
            SolidBrush rd = new SolidBrush(Color.Red);
            Pen p3 = new Pen(Color.Gray, 8);
            Pen p2 = new Pen(Color.Blue, 8);




            for (int x= 0; x< 400; x+=100)
            {
                for(int y=0; y< 400; y+=100)
                {
                    g.FillRectangle(rd, x, y, 50, 50);
                    g.FillRectangle(bl, x + 50, y, 50, 50);
                    g.FillRectangle(rd, x + 50, y + 50, 50, 50);
                    g.FillRectangle(bl, x, y + 50, 50, 50);
                }

            }
            for (int i = 0; i < s; i++) 
            {
                g.DrawEllipse(p3, fältx[i], fälty[i], 45, 45);
                
            }
            for (int i = 0; i < s2; i++)
            {
                g.DrawEllipse(p2, fältx2[i], fälty2[i], 45, 45);

            }

        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X / 50 * 50;
            int y = e.Y / 50 * 50;

            if (klocka % 2 == 0)
            {
                if (!(fältx.Contains(x) && fälty.Contains(y)))
                {

                    fältx[s] = x;
                    fälty[s] = y;
                    s++;
                    
                }
            }
            else
            {
                if (!(fältx2.Contains(x) && fälty2.Contains(y)))
                {
                    fältx2[s2] = x;
                    fälty2[s2] = y;
                    s2++;
                    
                }
                
            }



            klocka++;
            panel1.Invalidate();
            
        }
    }
}

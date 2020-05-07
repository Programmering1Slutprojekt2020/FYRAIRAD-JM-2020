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
        int[] fält = new int[100];
        int s = 0;
        int klocka = 0;
        Pen p3 = new Pen(Color.Gray, 8);

        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush bl = new SolidBrush(Color.Black);
            SolidBrush rd = new SolidBrush(Color.Red);
            Pen p1 = new Pen(Color.Green, 8);
            Pen p2 = new Pen(Color.White, 8);
            
            


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
            for (int i = 0; i < s; i += 2) 
            {
                g.DrawEllipse(p3, fält[i], fält[i + 1], 48, 48);
                
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (klocka % 2 == 0)
            { }
            else { } 
            int x = e.X / 50 * 50;
            int y = e.Y / 50 * 50;
            fält[s] = x;
            fält[s + 1] = y;
            s += 2;
            panel1.Invalidate();
            klocka++;
        }
    }
}

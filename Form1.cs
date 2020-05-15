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

        int[,] fältxy = new int[200, 200];
        bool win = false;
        bool s1 = true; 

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

            

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (fältxy[x, y] == 1)
                    {
                        g.DrawEllipse(p2, x * 50, y * 50, 48, 48);
                    }
                    if (fältxy[x, y] == 2)
                    {
                        g.DrawEllipse(p3, x * 50, y * 50, 48, 48);
                    }

                }

            }
            
            
                


        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X / 50;
            int y = e.Y / 50;
            if (s1)
            {
                if (fältxy[e.X / 50, e.Y / 50] == 0)
                {
                    fältxy[e.X / 50, e.Y / 50] = 1;
                    
                    s1 = false;
                }
            }
            else
            {
                if (fältxy[e.X / 50, e.Y / 50] == 0)
                {
                    fältxy[e.X / 50, e.Y / 50] = 2;
                    s1 = true;
                }
            }

            //Analys horisontellt
            //till höger
            int totalirad = 0; 
            int steg = 1; 
            while(fältxy[x,y] == fältxy[x +steg, y])
            {
                steg++;
            }
            totalirad = steg;
            //till vänster
            steg = 1;
            while (fältxy[x, y] == fältxy[x - steg, y])
            {
                steg++;
            }
            totalirad += steg-1;
            //check om det var fyra stycken
            if(totalirad >= 4)
            {
                win = true;

            }


            //analys vertikalt
            
            while (fältxy[x, y] == fältxy[x , y+steg])
            {
                steg++;
            }
            totalirad = steg;
            //nedåt
            steg = 1;
            while (fältxy[x, y] == fältxy[x , y - steg])
            {
                steg++;
            }
            totalirad += steg - 1;
            if(totalirad >=4)
            {
                win = true;
                    
            }

            //analys diagonalt

            while (fältxy[x, y] == fältxy[x+steg, y + steg])
            {
                steg++;
            }
            totalirad = steg;
            //snett nedåt
            steg = 1;
            while (fältxy[x, y] == fältxy[x-steg, y - steg])
            {
                steg++;
            }
            totalirad += steg - 1;
            if(totalirad >=4)
            {
                win = true;
            }

            if (win)
            {
                if (s1)//spelare 2 vinner
                {
                    panel1.Visible = false;
                    pictureBox22wins.Visible = true;
                }
                else//spelare 1 vinner
                {
                    panel1.Visible = false;
                    pictureBox11wins.Visible = true;
                }

            }










            panel1.Invalidate();
            
        }
    }
}

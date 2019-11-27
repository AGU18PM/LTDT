using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTDT
{
    public partial class fMain : Form
    {
        Graphics g;
        int count = 0;
        TheRoad theRoad;
        int cost = 0;
        int distance = 0;

        public fMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            theRoad = new TheRoad(Convert.ToInt32(txbStartPoint.Text) - 1, Convert.ToInt32(txbEnds.Text) - 1, Convert.ToInt32(txbCash.Text), Convert.ToInt32(nUDCityAmount.Value), Convert.ToInt32(nUDRoadAmount.Value));
            count = theRoad.RoadsAmount;
            addToComboBox();
            theRoad.createPosition();
            VeDoThi();
        }

        void addToComboBox()
        {
            for (int i = 1; i <= nUDCityAmount.Value; i++)
            {
                cboA.Items.Add(i);
                cboB.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                theRoad.Cost[Convert.ToInt32(cboA.Text) - 1, Convert.ToInt32(cboB.Text) - 1] = Convert.ToInt32(txbTS.Text);
                theRoad.Map[Convert.ToInt32(cboA.Text) - 1, Convert.ToInt32(cboB.Text) - 1] = Convert.ToInt32(txbDoDai.Text);
                theRoad.MinRoad[Convert.ToInt32(cboA.Text) - 1, Convert.ToInt32(cboB.Text) - 1] = Convert.ToInt32(txbDoDai.Text);
                theRoad.MinCost[Convert.ToInt32(cboA.Text) - 1, Convert.ToInt32(cboB.Text) - 1] = Convert.ToInt32(txbTS.Text);
                count--;
            }
            else
            {
                MessageBox.Show("Xong");
            }
            Point a = new Point(theRoad.X[Convert.ToInt32(cboA.Text) - 1], theRoad.Y[Convert.ToInt32(cboA.Text) - 1]);
            Point b = new Point(theRoad.X[Convert.ToInt32(cboB.Text) - 1], theRoad.Y[Convert.ToInt32(cboB.Text) - 1]);
            DrawALine(a, b, Convert.ToInt32(cboA.Text) - 1, Convert.ToInt32(cboB.Text) - 1, 0);
            DrawALine(a, b, Convert.ToInt32(cboA.Text) - 1, Convert.ToInt32(cboB.Text) - 1, 0);
        }

        private void VeDoThi()
        {

            for (int i = 0; i < theRoad.CitysAmount; i++)
            {
                paint(i);
            }
        }

        private void paint(int i)
        {
            Node n = new Node(i);
            Point location1 = new Point(0, 0);
            location1.X = theRoad.X[i];
            location1.Y = theRoad.Y[i];
            n.Location = location1;
            n.BackColor = Color.Green;

            //Node m = new Node(j);
            //Point location2 = new Point(0, 0);
            //location1.X = theRoad.X[j];
            //location1.Y = theRoad.Y[j];
            //m.Location = location2;
            //m.BackColor = Color.Green;
            pBDT.Controls.Add(n);
            //pBDT.Controls.Add(m);
            //DrawALine(n.Location, m.Location);
        }

        private void DrawALine(Point a, Point b, int i, int j, int isResult)
        {
            Point tg = new Point((a.X + b.X) / 2, (a.Y + b.Y) / 2);
            a.X += 12;
            a.Y += 12;
            b.X += 12;
            b.Y += 12;
            Pen pen = new Pen(Color.Red, 3);
            if (isResult == 0)
            {

            }
            else
            {
                pen = new Pen(Color.Blue, 3);
            }
            pen.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(pen, a, tg);
            Point tg2 = tg;
            tg2.X += 5;
            tg2.Y += 5;
            g.DrawString(theRoad.Cost[i, j].ToString(), this.Font, Brushes.BlueViolet, tg2);
            g.DrawLine(pen, tg, b);
            pBDT.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            theRoad.findTheMinCost();
            theRoad.findTheMinRoad();
            theRoad.result();
            drawAgain();
        }

        private void pBDT_Paint(object sender, PaintEventArgs e)
        {
            g = pBDT.CreateGraphics();
        }

        private void drawAgain()
        {
            for (int i = 0; i < theRoad.CitysAmount; i++)
            {
                for (int j = 0; j < theRoad.CitysAmount; j++)
                {
                    if (theRoad.Cost[i, j] != 0 && theRoad.Cost[i, j] != int.MaxValue)
                    {
                        Point a = new Point(theRoad.X[i], theRoad.Y[i]);
                        Point b = new Point(theRoad.X[j], theRoad.Y[j]);
                        DrawALine(a, b, i, j, 0);
                        DrawALine(a, b, i, j, 0);
                    }
                }
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            DrawResult();
            int sotien = theRoad.MinCost[Convert.ToInt32(txbStartPoint.Text) - 1, Convert.ToInt32(txbEnds.Text) - 1];
            int dodai = 0;
            for(int i =0; i < theRoad.RoadsCount-1; i++)
            {
                dodai += theRoad.Map[theRoad.Road[i], theRoad.Road[i+1]];
            }
            MessageBox.Show("Do dai: "+ dodai.ToString());
            MessageBox.Show("So tien: " + sotien.ToString());

        }

        private void DrawResult()
        {
            for (int i = 0; i < theRoad.RoadsCount-1; i++)
            {
                Point a = new Point(theRoad.X[theRoad.Road[i]], theRoad.Y[theRoad.Road[i]]);
                Point b = new Point(theRoad.X[theRoad.Road[i + 1]], theRoad.Y[theRoad.Road[i + 1]]);
                DrawALine(a, b, i, i + 1, 1);
                DrawALine(a, b, i, i + 1, 1);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTDT
{
    public partial class fMain : Form
    {
        Graphics g;
        int isKQ = 0;
        TheRoad theRoadtg = new TheRoad(0, 0, 0, 0, 0);
        int count = 0;
        TheRoad theRoad;
        int isFirst = 1;
        Color a;
        string reSulr = "";

        public fMain()
        {
            InitializeComponent();
            a = pBDT.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isKQ = 0;
            if (isFirst == 1)
            {
                isFirst = 0;
                theRoad = new TheRoad(Convert.ToInt32(txbStartPoint.Text) - 1, Convert.ToInt32(txbEnds.Text) - 1, 
                    Convert.ToInt32(txbCash.Text), Convert.ToInt32(nUDCityAmount.Value), Convert.ToInt32(nUDRoadAmount.Value));
                count = theRoad.RoadsAmount;
                addToComboBox();
                theRoad.createPosition();
            }
            else
            {
                theRoad.StartPoint = (Convert.ToInt32(txbStartPoint.Text)) - 1;
                theRoad.Ends = Convert.ToInt32(txbEnds.Text) - 1;
                theRoad.Cash = Convert.ToInt32(txbCash.Text);
                theRoad.RoadsCount = 0;
            }
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
            if(count==0)
            {
                button2.Enabled = false;
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
            pBDT.Controls.Add(n);            
        }

        private void DrawALine(Point a, Point b, int i, int j, int isResult)
        {
            Point tg = new Point((a.X + b.X) / 2, (a.Y + b.Y) / 2);
            a.X += 12;
            a.Y += 12;
            b.X += 12;
            b.Y += 12;
            Pen pen = new Pen(Color.Red, 1);
            if (isResult == 0)
            {

            }
            else
            {
                pen = new Pen(Color.Blue, 1);
            }
            pen.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(pen, a, tg);
            Point tg2 = tg;
            tg2.X += 5;
            tg2.Y += 5;
            if (theRoad.Cost[i, j] == int.MaxValue)
            {

            }
            else if (isKQ == 0)
            {
                g.DrawString(theRoad.Cost[i, j].ToString(), this.Font, Brushes.BlueViolet, tg2);
            }

            g.DrawLine(pen, tg, b);
            pBDT.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PictureBox PositionIcon = new PictureBox();
            Size s = new Size(20, 20);
            PositionIcon.Size = s;
            PositionIcon.BackgroundImage = Image.FromFile(@"C:\Users\thait\Documents\GitHub\LTDT\IMG\icon-gps-2.jpg");
            PositionIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pBDT.Controls.Add(PositionIcon);
            Point loc = new Point(theRoad.X[theRoad.Ends] + 2, theRoad.Y[theRoad.Ends] - 20);
            PositionIcon.Location = loc;
            
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
            isKQ = 1;
            if (theRoad.Cash >= theRoad.MinCost[theRoad.StartPoint, theRoad.Ends])
            {
                DrawResult();
                int sotien = theRoad.MinCost[theRoad.StartPoint, theRoad.Ends];
                int dodai = 0;
                for (int i = 0; i < theRoad.RoadsCount - 1; i++)
                {
                    dodai += theRoad.Map[theRoad.Road[i], theRoad.Road[i + 1]];
                }
                reSulr = "Độ dài: " + dodai.ToString();
                reSulr += "\n";
                reSulr += "Chi phí: " + sotien.ToString();
                reSulr += "\n";
                string a = "Đoạn đường đi từ "+(theRoad.StartPoint+1)+"->"+(theRoad.Ends+1)+": ";
                for (int i = 0; i < theRoad.RoadsCount-1; i++)
                {
                    a += (theRoad.Road[i] + 1).ToString() +"-->";
                }
                a += (theRoad.Ends+1);
                MessageBox.Show(reSulr+=a);
            }
            else
            {
                reSulr = "Không tìm được!!!";
                MessageBox.Show(reSulr);
            }


        }

        private void DrawResult()
        {
            for (int i = 0; i < theRoad.RoadsCount - 1; i++)
            {
                Point a = new Point(theRoad.X[theRoad.Road[i]], theRoad.Y[theRoad.Road[i]]);
                Point b = new Point(theRoad.X[theRoad.Road[i + 1]], theRoad.Y[theRoad.Road[i + 1]]);
                DrawALine(a, b, i, i + 1, 1);
                DrawALine(a, b, i, i + 1, 1);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string s = "";
            OpenFileDialog open = new OpenFileDialog();
            DialogResult rs = open.ShowDialog();
            if (rs == DialogResult.OK)
            {
                isFirst = 0;
                FileStream fs = new FileStream(open.FileName, FileMode.Open);
                StreamReader doc = new StreamReader(fs);
                s = doc.ReadLine();
                s.Trim();
                List<int> kq = ToInt(s);
                int start = kq[0] - 1;
                int ends = kq[1] - 1;
                int cash = kq[2];

                s = doc.ReadLine();
                s.Trim();
                kq = ToInt(s);
                int dinh = kq[0];

                s = doc.ReadLine();
                s.Trim();
                kq = ToInt(s);
                int canh = kq[0];
                theRoad = new TheRoad(start, ends, cash, dinh, canh);
                theRoad.createPosition();
                VeDoThi();
                for (int i = 0; i < canh; i++)
                {
                    s = doc.ReadLine();
                    s.Trim();
                    kq = ToInt(s);
                    theRoad.Cost[kq[0] - 1, kq[1] - 1] = kq[3];
                    theRoad.Map[kq[0] - 1, kq[1] - 1] = kq[2];
                    theRoad.MinCost[kq[0] - 1, kq[1] - 1] = kq[3];
                    theRoad.MinRoad[kq[0] - 1, kq[1] - 1] = kq[2];

                    Point a = new Point(theRoad.X[kq[0] - 1], theRoad.Y[kq[0] - 1]);
                    Point b = new Point(theRoad.X[kq[1] - 1], theRoad.Y[kq[1] - 1]);
                    DrawALine(a, b, kq[0] - 1, kq[1] - 1, 0);
                    DrawALine(a, b, kq[0] - 1, kq[1] - 1, 0);

                }
                fs.Close();
            }
        }

        private List<int> ToInt(string input)
        {
            List<int> result = new List<int>();
            input = input.Trim();
            string[] temp = input.Split(' ');
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].Trim().Length != 0)
                {
                    result.Add(int.Parse(temp[i].Trim()));
                }
            }

            return result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "Csharp |*.cs";
            save.Filter = "txt file (.txt)|*.txt|CSharp(.cs)|*.cs|C++(.cpp)|*.cpp|All file(*.*)|*.*";
            save.Title = "Save a file......";
            DialogResult kq = save.ShowDialog();
            if (kq == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(save.FileName);
                file.Write(reSulr);
                file.Close();
            }
            
        }

        private void btnSaveImg_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pBDT.Width, pBDT.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics anh = Graphics.FromImage(bmp);

            anh.CopyFromScreen(PointToScreen(pBDT.Location).X, PointToScreen(pBDT.Location).Y, 0, 0, pBDT.Size, CopyPixelOperation.SourceCopy);

            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "Csharp |*.cs";
            save.Filter = "JPEG|*.jpg";
            save.Title = "Save a file......";
            DialogResult kq = save.ShowDialog();
            if (kq == DialogResult.OK)
            {
                bmp.Save(save.FileName);
            }
        }
    }
}

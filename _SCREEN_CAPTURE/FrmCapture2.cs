﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _SCREEN_CAPTURE
{
    public partial class FrmCapture2 : Form
    {
        private MoveControl moveControl;
        private Bitmap sourceScreen; 
        public FrmCapture2(Bitmap bmp)
        {
            Console.WriteLine("FrmCapture2 init");
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //this.BackgroundImage = bmp;
            sourceScreen = bmp;
            this.Location = new Point(0, 0);            
            int width = Gvar.getSize().Width;
            int height = Gvar.getSize().Height;

            this.Size = new Size(width,
                height);
            var darkBmp = Gvar.imgColorBrightness(sourceScreen, 125, 0, 0, width,height);
            this.pictureBox1.Image = darkBmp;
            this.pictureBox1.Size = new Size(width,
                height);
            this.pictureBox1.Height = Gvar.getSize().Height;
            this.pictureBox1.Location = new Point(0, 0);
            pictureBox1.SendToBack();

            this.TopMost = true;
            this.ShowInTaskbar = false;

            //panel1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(-100, -100);
            
            //Console.WriteLine(label1.Location);

            pictureBox2.Size = new Size(sourceScreen.Width, sourceScreen.Width);
            pictureBox2.Image = sourceScreen;
            
            Console.WriteLine("pictureBox2.size: " + pictureBox2.Size);
            moveControl = new MoveControl(panel1, pictureBox2);
            //trackBar1.Maximum = 255;
            Console.WriteLine("FrmCapture2 init finished");



            //tBtn_Rect.Click += new EventHandler(selectToolButton_Click);
            //tBtn_Ellipse.Click += new EventHandler(selectToolButton_Click);
            //tBtn_Arrow.Click += new EventHandler(selectToolButton_Click);
            //tBtn_Brush.Click += new EventHandler(selectToolButton_Click);
            //tBtn_Text.Click += new EventHandler(selectToolButton_Click);
            tBtn_Close.Click += (s, e) => this.Close();

            Gvar.isDrawing = false;

        }


        private void selectToolButton_Click(object sender, EventArgs e)
        {
            panel3.Visible = ((ToolButton)sender).IsSelected;
            //if (panel3.Visible) panel1.CanReset = false;
            //else { panel1.CanReset = m_layer.Count == 0; }
            this.SetToolBarLocation();
        }

        private void SetToolBarLocation()
        {
            int tempX = panel2.Left;
            int tempY = panel2.Bottom + 5;
            int tempHeight = panel3.Visible ? panel3.Height + 2 : 0;
            if (tempY + panel2.Height + tempHeight >= this.Height)
                tempY = panel2.Top - panel2.Height - 10 - panel2.Font.Height;

            if (tempY - tempHeight <= 0)
            {
                if (panel2.Top - 5 - panel2.Font.Height >= 0)
                    tempY = panel2.Top + 5;
                else
                    tempY = panel2.Top + 10 + panel2.Font.Height;
            }
            if (tempX + panel2.Width >= this.Width)
                tempX = this.Width - panel2.Width - 5;
           // panel2.Left = tempX;
            panel3.Left = tempX;
            //panel2.Top = tempY;
            panel3.Top = panel2.Top > tempY ? tempY - tempHeight : panel2.Bottom + 2;
        }



        private void FrmCapture2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("FrmCapture2_KeyPress: " + e.KeyChar);
            if (e.KeyChar == 27)
            {
                this.Close();
                return;
            }
        }

        public bool isDraweing  = false;
        public Point startPoint;
        private bool isBoxSelection;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("pictureBox1_MouseDown: ");
            if (e.Button == MouseButtons.Left)
            {
                if (moveControl != null && moveControl.fc != null)
                { 

                    //Console.WriteLine("moveControl.fc: " + moveControl.fc);

                    //moveControl.fc.Visible = false;
                    panel1.Parent.Controls.Remove(moveControl.fc);
                }
                

                // 点击截图
                Console.WriteLine("框选截图 ");
                isBoxSelection = true;
                var p = new Point(e.Location.X, e.Location.Y);
                panel1.Visible = true;
                //Console.WriteLine("before  panel1.Location: " + panel1.Location);
                panel1.Location = p;
                //Console.WriteLine("after panel1.Location: " + panel1.Location);
                pictureBox2.Visible = true;

                startPoint = p;
                isDraweing = true;

                // 相对于 panel
                pictureBox2.Location = new Point(-e.Location.X, -e.Location.Y);
                //moveControl.MouseClick(sender, e); 


            }
            else if (e.Button == MouseButtons.Right)
            {

            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        { 
            Console.WriteLine("pictureBox1_MouseClick: " + isDraweing + " , location: " +e.Location);
            if (e.Button == MouseButtons.Left) {

                if (isBoxSelection)
                {
                    return;
                }

                // 点击截图
                Console.WriteLine("点击截图 " );
                isBoxSelection = false;
                var p = new Point(e.Location.X, e.Location.Y);
                panel1.Visible = true;
                Console.WriteLine("before  panel1.Location: " + panel1.Location);
                panel1.Location= p;
                Console.WriteLine("after panel1.Location: " + panel1.Location);
                pictureBox2.Visible = true;
                
                startPoint = p;
                isDraweing = true;

                // 相对于 panel
                pictureBox2.Location = new Point(-e.Location.X, -e.Location.Y);
                moveControl.MouseClick(sender, e);

            }

            if (e.Button == MouseButtons.Right)

            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("pictureBox1_MouseMove: " + e.Button + " , location: " + e.Location);
            //Console.WriteLine("pictureBox1_MouseMove: " + e.Button + " , location: " + e.Location);
            if (e.Button == MouseButtons.Left)
            {
                int w = Math.Abs( e.X - startPoint.X);
                int h = Math.Abs(e.Y - startPoint.Y);
                panel1.Visible = true;
                panel1.Size = new Size(w, h);
                
                isDraweing = true;
                 
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("pictureBox1_MouseUp: " + isDraweing);
            if (e.Button == MouseButtons.Left)
            {
                isDraweing = false;
                isBoxSelection = false;
                moveControl.MouseClick(sender, e);


                // 展示编辑栏
                
                panel2.Visible = true;
                panel2.Location = new Point(panel1.Location.X + panel1.Width-panel2.Width , panel1.Location.Y + panel1.Height+15 );
                panel2.BringToFront();
                Console.WriteLine("panel2.Location : " + panel2.Location);

                Bitmap bmp = new Bitmap(panel1.Width,
                       panel1.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(panel1.Location.X, panel1.Location.Y, 0, 0, bmp.Size);
                }
                m_bmpLayerCurrent = bmp;

            } 
        }

       
        

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Console.WriteLine("pictureBox1_PreviewKeyDown: " + e.KeyCode);
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Console.WriteLine("panel1_PreviewKeyDown: " + e.KeyCode);
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pictureBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Console.WriteLine("pictureBox2_PreviewKeyDown: " + e.KeyCode);
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("panel1_MouseClick: " + e.Button);
          

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("pictureBox2_MouseClick: " + e.Button);
            //
            
            //panel1.Controls.Remove(moveControl.fc);
        }

        private void FrmCapture2_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("FrmCapture2_MouseClick: " + e.Button);
            
        }
  

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("panel1_MouseMove: " + e.Button);
        }

        private void FrmCapture2_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("FrmCapture2_MouseMove: " + e.Button);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("panel1_MouseUp: " + e.Button);
        }
 
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (Gvar.isDrawing)
            {
                return;
            }
            Console.WriteLine("pictureBox2_MouseUp: " + e.Button);
            moveControl.MouseUp(sender, e);
            
            var a = new MouseEventArgs(e.Button, e.Clicks, Cursor.Position.X- this.pointInPanel1.X, Cursor.Position.Y- this.pointInPanel1.Y, e.Delta);
            pictureBox1_MouseClick (sender, a);
            pictureBox1_MouseUp(sender, a);
            if (moveControl.fc != null)
            {
                moveControl.fc.Visible = true;
            }
        }
        
 

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("label1_Click: " + MouseButtons);
        }

        private void panel1_LocationChanged(object sender, EventArgs e)
        {
            Console.WriteLine("panel1_LocationChanged: " + panel1.Location);
            //string info = null;
            //StackTrace st = new StackTrace(true);
            ////得到当前的所以堆栈
            //StackFrame[] sf = st.GetFrames();
            //for (int i = 0; i < sf.Length; ++i)
            //{
            //    info = info + "\r\n" + " FileName=" + sf[i].GetFileName() + " fullname=" + sf[i].GetMethod().DeclaringType.FullName + " function=" + sf[i].GetMethod().Name + " FileLineNumber=" + sf[i].GetFileLineNumber();
            //}
            //Console.WriteLine("panel1_LocationChanged: " + info);
        }


        // 记录拖放的起点
        private Point pointInPanel1;
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (Gvar.isDrawing)
            {
                return;
            }
            Console.WriteLine("pictureBox2_MouseDown: " + e.Button);
            moveControl.MouseDown(sender, e);
            if (e.Button == MouseButtons.Left)
            {
                this.pointInPanel1.X = e.X - panel1.Location.X;
                this.pointInPanel1.Y = e.Y - panel1.Location.Y;
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Gvar.isDrawing)
            {
                return;
            }
            Console.WriteLine("pictureBox2_MouseMove: " + " ,Location: " + e.Location);
            //var a = new MouseEventArgs(e.Button,e.Clicks,e.X,e.Y,e.Delta);
            moveControl.MouseMove(sender, e);
            if (e.Button== MouseButtons.Left && isDraweing)
            {
                var p = new Point(e.Location.X, e.Location.Y);
                panel1.Location = p;
                panel1.Visible = true;
                pictureBox2.Visible = true;

                startPoint = p;
                isDraweing = true;

                // 相对于 panel
                pictureBox2.Location = new Point(-e.Location.X, -e.Location.Y);
                moveControl.MouseClick(sender, e);
            }
            
        }
         
        private void pictureBox2_LocationChanged(object sender, EventArgs e)
        {
            Console.WriteLine("pictureBox2_LocationChanged: " + pictureBox2.Location);
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("panel1_SizeChanged: " + panel1.Width);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine("pictureBox2_MouseEnter: " + panel1.Width);
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("pictureBox2_DragEnter: " + panel1.Width);
        }

        private void pictureBox2_Move(object sender, EventArgs e)
        {
            Console.WriteLine("pictureBox2_Move: " );
        }

        private void pin在桌面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            
            new FrmPin(m_bmpLayerCurrent).Show();
            this.Close();
            
        }

        private Bitmap m_bmpLayerCurrent;

        private void tBtn_Save_Click(object sender, EventArgs e)
        {
            //m_bSave = true;
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg";
            saveDlg.FilterIndex = 2;
            saveDlg.FileName = "CAPTURE_" + Gvar.GetTimeString();
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                switch (saveDlg.FilterIndex)
                {
                    case 1:
                        m_bmpLayerCurrent.Clone(new Rectangle(0, 0, m_bmpLayerCurrent.Width, m_bmpLayerCurrent.Height),
                            System.Drawing.Imaging.PixelFormat.Format24bppRgb).Save(saveDlg.FileName,
                            System.Drawing.Imaging.ImageFormat.Bmp);
                        this.Close();
                        break;
                    case 2:
                        m_bmpLayerCurrent.Save(saveDlg.FileName,
                            System.Drawing.Imaging.ImageFormat.Jpeg);
                        this.Close();
                        break;
                }
            }
            //m_bSave = false;
        }

        private void tBtn_Finish_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(m_bmpLayerCurrent);
            this.Close();
        }

        private void tBtn_Rect_Click(object sender, EventArgs e)
        {
            Console.WriteLine("tBtn_Rect_Click");
            Cursor.Current = Cursors.Default;
            Gvar.isDrawing = true;
          
        }
    }
}


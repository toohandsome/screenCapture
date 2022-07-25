using System;
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

            panel1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(-100, -100);
            pictureBox2.Image = sourceScreen;

            Console.WriteLine(label1.Location);

            pictureBox2.Size = new Size(sourceScreen.Width, sourceScreen.Width);
            pictureBox2.Image = sourceScreen;

            moveControl = new MoveControl(panel1);
            //trackBar1.Maximum = 255;
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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        { 
            Console.WriteLine("pictureBox1_MouseClick: " + isDraweing + " , location: " +e.Location);
            if (e.Button == MouseButtons.Left) {

                // 框选截图

                var p = new Point(e.Location.X, e.Location.Y);
                panel1.Location= p;
                panel1.Visible = true;
                pictureBox2.Visible = true;
                
                startPoint = p;
                isDraweing = true;

                // 相对于 panel
                pictureBox2.Location = new Point(-e.Location.X, -e.Location.Y);
                moveControl.MouseClick(sender, e);

            }

            if (e.Button == MouseButtons.Right)
            {

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("pictureBox1_MouseMove: " + e.Button + " , location: " + e.Location);
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
            } 
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Console.WriteLine("trackBar1.Value: " + trackBar1.Value);
            label1.Text = trackBar1.Value+"";
          // var a=  Gvar.imgColorBrightness(sourceScreen, trackBar1.Value, 0, 0, 200, 400);
           // pictureBox1.Image = a;
           // Gvar.BrightnessP(sourceScreen, trackBar1.Value);
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

        
        

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("label1_Click: " + MouseButtons);
        }

        private void panel1_LocationChanged(object sender, EventArgs e)
        {
            Console.WriteLine("panel1_LocationChanged: " + panel1.Location);
            string info = null;
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
            Console.WriteLine("pictureBox2_MouseMove: " + e.Button + " ,Location: " + e.Location);
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

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("pictureBox2_MouseUp: " + e.Button);
            moveControl.MouseUp(sender, e);

            var a = new MouseEventArgs(e.Button, e.Clicks, Cursor.Position.X - this.pointInPanel1.X, Cursor.Position.Y - this.pointInPanel1.Y, e.Delta);
            pictureBox1_MouseClick(sender, a);
            pictureBox1_MouseUp(sender, a);
        }
        private void pictureBox2_LocationChanged(object sender, EventArgs e)
        {
            Console.WriteLine("pictureBox2_LocationChanged: " + pictureBox2.Location);
        }
    }
}


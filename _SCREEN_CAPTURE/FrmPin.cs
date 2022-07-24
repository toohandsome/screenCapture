using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _SCREEN_CAPTURE
{
    public partial class FrmPin : Form
    {
        private Point _mousePoint;
        public FrmPin(Bitmap bmp)
        {
            InitializeComponent();
            this.pictureBox1.Image = bmp;
            this.pictureBox1.Width = bmp.Width;
            this.pictureBox1.Height = bmp.Height;
            this.Width = bmp.Width+4;
            this.Height = bmp.Height+4;

            this.Location = new Point(MousePosition.X-(this.Width/2),MousePosition.Y - (this.Height / 2));
            


        }



        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)

            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                _mousePoint.X = e.X;

                _mousePoint.Y = e.Y;

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                Top = MousePosition.Y - _mousePoint.Y;

                Left = MousePosition.X - _mousePoint.X;

            }
        }

        private void FrmPin_Resize(object sender, EventArgs e)
        {
            Point p2 = new Point((this.Width - pictureBox1.Width) / 2, (this.Height - pictureBox1.Height) / 2);

            pictureBox1.Location = p2;
        }
    }
}

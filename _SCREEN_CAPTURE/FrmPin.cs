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

        }

       

            private void FrmPin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                Top = MousePosition.Y - _mousePoint.Y;

                Left = MousePosition.X - _mousePoint.X;

            }
        }

        private void FrmPin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                _mousePoint.X = e.X;

                _mousePoint.Y = e.Y;

            }
        }

        private void FrmPin_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)

            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using Newtonsoft.Json.Linq;
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
    public partial class FrmOrcResult : Form
    {
        private Bitmap m_bmpLayerCurrent;
        public FrmOrcResult(Bitmap bmp, string ocrText)
        {
            Console.WriteLine("FrmOrcResult init ");
            InitializeComponent();
            JObject ocrJson = JObject.Parse(ocrText);
            var words = ocrJson["words_result"].ToArray();
            var fullStr = "";
            Console.WriteLine("length: " + words.Length);
            int max = 0;
            for (int i = 0; i < words.Length; i++)
            {
                var tempWord = words[i];
                var wordStr = tempWord["words"].ToString();
                if (max < wordStr.Length)
                {
                    max = wordStr.Length;
                }
                fullStr += wordStr + "\r\n";
            }
            textBox1.Height = words.Length* 38;
            textBox1.Text = fullStr; 
            pictureBox1.Image = bmp;
            m_bmpLayerCurrent = bmp;
            panel1.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);

            Graphics g = this.textBox1.CreateGraphics();
            System.Drawing.SizeF s = g.MeasureString(this.textBox1.Text, this.textBox1.Font);
            this.textBox1.Height = (int)s.Height + 50;
            this.textBox1.Width = (int)s.Width + 10;


            int width = pictureBox1.Image.Width + 200 + this.textBox1.Width;


            if (width > Gvar.getSize().Width * 0.9)
            {
                this.panel1.Dock = DockStyle.Top;
                this.splitter1.Dock = DockStyle.Top;
                
                this.splitter1.Cursor = Cursors.HSplit;
                this.panel2.Dock = DockStyle.Fill;

                if (pictureBox1.Image.Width > this.textBox1.Width)
                {
                    this.Width = pictureBox1.Image.Width + 100;
                }
                else {
                    this.Width = this.textBox1.Width + 100;
                }

                this.Height = pictureBox1.Image.Height + textBox1.Height + 300 ;
                this.panel1.Height = pictureBox1.Image.Height + 50;


            }
            else {
                this.Width = width;
                int height = 0;
                if (pictureBox1.Image.Height > textBox1.Height)
                {
                    height = pictureBox1.Image.Height + 200;
                }
                else
                {
                    height = textBox1.Height  + 200;
                }
                this.Height = height;
                panel1.Width = pictureBox1.Image.Width + 50;
                textBox1.Width = max * 30;
            }
            

            resize();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {            
            //textBox1.Height = textBox1.Lines.Length * 38;
            //if (textBox1.Height < 250) {
            //    textBox1.Height = 250;
            //}

             
        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
         

         

        public void resize() { 




            Point p = new Point(0, (this.panel2.Height - textBox1.Height) / 2);
            Point p1 = new Point(50, 27); 
            textBox1.Location = p; 
            Console.WriteLine("resize1:  width: " + (this.panel2.Width  - 100));
            button1.Location = p1;

            if (pictureBox1.Image != null)
            {
                pictureBox1.Width = pictureBox1.Image.Width;
                pictureBox1.Height = pictureBox1.Image.Height;
            }
           
          
            Point p2 = new Point((this.panel1.Width - pictureBox1.Width)/2, (this.panel1.Height - pictureBox1.Height) / 2);
            
            pictureBox1.Location = p2;
            
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void pinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPin(m_bmpLayerCurrent.Clone() as Bitmap).Show();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)

            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }
    }
}

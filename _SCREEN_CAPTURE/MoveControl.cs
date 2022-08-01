using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace _SCREEN_CAPTURE
{
    class MoveControl
    { 
        #region Constructors
        public MoveControl(Control ctrl, Control imgbox)
        { 
            currentControl = ctrl;
            imgbox2 = imgbox;
            AddEvents();
        }
        #endregion
        #region Fields
        private Control currentControl; //传入的控件
        private Control imgbox2; //传入的控件
        private Point pPoint; //上个鼠标坐标
        private Point cPoint; //当前鼠标坐标
        public FrameControl fc;//边框控件
        #endregion
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// 挂载事件
        /// </summary>
        private void AddEvents()
        {
            currentControl.MouseClick += new MouseEventHandler(MouseClick);
            currentControl.MouseDown += new MouseEventHandler(MouseDown);
            currentControl.MouseMove += new MouseEventHandler(MouseMove);
            currentControl.MouseUp += new MouseEventHandler(MouseUp);
            
        }
        /// <summary>
        /// 绘制拖拉时的黑色边框
        /// </summary>
        public static void DrawDragBound(Control ctrl)
        {
            ctrl.Refresh();
            Graphics g = ctrl.CreateGraphics();
            int width = ctrl.Width;
            int height = ctrl.Height;
            Point[] ps = new Point[5]{new Point(0,0),new Point(width -1,0),
   new Point(width -1,height -1),new Point(0,height-1),new Point(0,0)};
            g.DrawLines(new Pen(Color.Black), ps);
        }
        #endregion
        #region Events
        /// <summary>
        /// 鼠标单击事件：用来显示边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(currentControl.Name + " MouseClick , location: " + e.Location);
            this.currentControl.Parent.Refresh();//刷新父容器，清除掉其他控件的边框
            this.currentControl.BringToFront();
            
            //fc = new FrameControl(this.currentControl);
            if (fc != null) fc.Dispose();
            fc = new FrameControl(this.currentControl);
            this.currentControl.Parent.Controls.Add(fc);
            fc.Visible = true;
            fc.Draw(); 
        }
        /// <summary>
        /// 鼠标按下事件：记录当前鼠标相对窗体的坐标
        /// </summary>
        public void MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mc MouseDown isDrawing: " + Gvar.isDrawing);
            if (Gvar.isDrawing)
            {
                return;
            }
            pPoint = Cursor.Position;
        }
        /// <summary>
        /// 鼠标移动事件：让控件跟着鼠标移动
        /// </summary>
        public void MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mc MouseMove isDrawing: " + Gvar.isDrawing);
            if (Gvar.isDrawing)
            {
                return;
            }
            Console.WriteLine(currentControl.Name + " MouseMove ");
            Cursor.Current = Cursors.SizeAll; //当鼠标处于控件内部时，显示光标样式为SizeAll
                                              //当鼠标左键按下时才触发
            if (e.Button == MouseButtons.Left)
            {
                MoveControl.DrawDragBound(this.currentControl);
                if (fc != null) fc.Visible = false; //先隐藏
                cPoint = Cursor.Position;//获得当前鼠标位置
                int x = cPoint.X - pPoint.X;
                int y = cPoint.Y - pPoint.Y;
                currentControl.Location = new Point(currentControl.Location.X + x, currentControl.Location.Y + y);
                Console.WriteLine("pPoint: " + pPoint + " , cPoint: " + cPoint+ " , currentControl.Location: " + currentControl.Location);
                pPoint = cPoint;

                // 改变 pictureBox2.Location 
                imgbox2.Location = new Point(-currentControl.Location.X, -currentControl.Location.Y);


            }
        }
        /// <summary>
        /// 鼠标弹起事件：让自定义的边框出现
        /// </summary>
        public void MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mc MouseUp isDrawing: " + Gvar.isDrawing);
            if (Gvar.isDrawing)
            {
                return;
            }
            Console.WriteLine(currentControl.Name + " MouseUp ");
            this.currentControl.Refresh();
            if (fc != null)
            {
                //fc.Visible = true;
                fc.Draw();
            }
        }
        #endregion
    }
}
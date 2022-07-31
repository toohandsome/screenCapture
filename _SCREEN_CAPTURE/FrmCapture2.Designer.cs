
namespace _SCREEN_CAPTURE
{
    partial class FrmCapture2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCapture2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pin在桌面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolButton5 = new _SCREEN_CAPTURE.ToolButton();
            this.toolButton4 = new _SCREEN_CAPTURE.ToolButton();
            this.tBtn_Finish = new _SCREEN_CAPTURE.ToolButton();
            this.tBtn_Close = new _SCREEN_CAPTURE.ToolButton();
            this.tBtn_Save = new _SCREEN_CAPTURE.ToolButton();
            this.tBtn_Cancel = new _SCREEN_CAPTURE.ToolButton();
            this.tBtn_Text = new _SCREEN_CAPTURE.ToolButton();
            this.tBtn_Brush = new _SCREEN_CAPTURE.ToolButton();
            this.tBtn_Arrow = new _SCREEN_CAPTURE.ToolButton();
            this.tBtn_Ellipse = new _SCREEN_CAPTURE.ToolButton();
            this.tBtn_Rect = new _SCREEN_CAPTURE.ToolButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(519, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 200);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            this.panel1.LocationChanged += new System.EventHandler(this.panel1_LocationChanged);
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panel1_PreviewKeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox2.Location = new System.Drawing.Point(72, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.LocationChanged += new System.EventHandler(this.pictureBox2_LocationChanged);
            this.pictureBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox2_DragEnter);
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            this.pictureBox2.Move += new System.EventHandler(this.pictureBox2_Move);
            this.pictureBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBox2_PreviewKeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pin在桌面ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 28);
            // 
            // pin在桌面ToolStripMenuItem
            // 
            this.pin在桌面ToolStripMenuItem.Name = "pin在桌面ToolStripMenuItem";
            this.pin在桌面ToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.pin在桌面ToolStripMenuItem.Text = "pin 在桌面";
            this.pin在桌面ToolStripMenuItem.Click += new System.EventHandler(this.pin在桌面ToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolButton5);
            this.panel2.Controls.Add(this.toolButton4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.tBtn_Finish);
            this.panel2.Controls.Add(this.tBtn_Close);
            this.panel2.Controls.Add(this.tBtn_Save);
            this.panel2.Controls.Add(this.tBtn_Cancel);
            this.panel2.Controls.Add(this.tBtn_Text);
            this.panel2.Controls.Add(this.tBtn_Brush);
            this.panel2.Controls.Add(this.tBtn_Arrow);
            this.panel2.Controls.Add(this.tBtn_Ellipse);
            this.panel2.Controls.Add(this.tBtn_Rect);
            this.panel2.Location = new System.Drawing.Point(31, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 31);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_SCREEN_CAPTURE.Properties.Resources.separator;
            this.pictureBox3.Location = new System.Drawing.Point(218, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::_SCREEN_CAPTURE.Properties.Resources.separator;
            this.pictureBox4.Location = new System.Drawing.Point(153, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 17);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBox1_PreviewKeyDown);
            // 
            // toolButton5
            // 
            this.toolButton5.BtnImage = ((System.Drawing.Image)(resources.GetObject("toolButton5.BtnImage")));
            this.toolButton5.IsSelected = false;
            this.toolButton5.IsSelectedBtn = false;
            this.toolButton5.IsSingleSelectedBtn = false;
            this.toolButton5.Location = new System.Drawing.Point(263, 3);
            this.toolButton5.Name = "toolButton5";
            this.toolButton5.Size = new System.Drawing.Size(21, 21);
            this.toolButton5.TabIndex = 13;
            // 
            // toolButton4
            // 
            this.toolButton4.BtnImage = ((System.Drawing.Image)(resources.GetObject("toolButton4.BtnImage")));
            this.toolButton4.IsSelected = false;
            this.toolButton4.IsSelectedBtn = false;
            this.toolButton4.IsSingleSelectedBtn = false;
            this.toolButton4.Location = new System.Drawing.Point(232, 2);
            this.toolButton4.Name = "toolButton4";
            this.toolButton4.Size = new System.Drawing.Size(21, 21);
            this.toolButton4.TabIndex = 12;
            // 
            // tBtn_Finish
            // 
            this.tBtn_Finish.BtnImage = global::_SCREEN_CAPTURE.Properties.Resources.ok;
            this.tBtn_Finish.IsSelected = false;
            this.tBtn_Finish.IsSelectedBtn = false;
            this.tBtn_Finish.IsSingleSelectedBtn = false;
            this.tBtn_Finish.Location = new System.Drawing.Point(407, 3);
            this.tBtn_Finish.Name = "tBtn_Finish";
            this.tBtn_Finish.Size = new System.Drawing.Size(21, 21);
            this.tBtn_Finish.TabIndex = 8;
            this.tBtn_Finish.Click += new System.EventHandler(this.tBtn_Finish_Click);
            // 
            // tBtn_Close
            // 
            this.tBtn_Close.BtnImage = global::_SCREEN_CAPTURE.Properties.Resources.close;
            this.tBtn_Close.IsSelected = false;
            this.tBtn_Close.IsSelectedBtn = false;
            this.tBtn_Close.IsSingleSelectedBtn = false;
            this.tBtn_Close.Location = new System.Drawing.Point(372, 3);
            this.tBtn_Close.Name = "tBtn_Close";
            this.tBtn_Close.Size = new System.Drawing.Size(21, 21);
            this.tBtn_Close.TabIndex = 7;
            // 
            // tBtn_Save
            // 
            this.tBtn_Save.BtnImage = global::_SCREEN_CAPTURE.Properties.Resources.save;
            this.tBtn_Save.IsSelected = false;
            this.tBtn_Save.IsSelectedBtn = false;
            this.tBtn_Save.IsSingleSelectedBtn = false;
            this.tBtn_Save.Location = new System.Drawing.Point(326, 3);
            this.tBtn_Save.Name = "tBtn_Save";
            this.tBtn_Save.Size = new System.Drawing.Size(21, 21);
            this.tBtn_Save.TabIndex = 6;
            this.tBtn_Save.Click += new System.EventHandler(this.tBtn_Save_Click);
            // 
            // tBtn_Cancel
            // 
            this.tBtn_Cancel.BtnImage = global::_SCREEN_CAPTURE.Properties.Resources.cancel;
            this.tBtn_Cancel.IsSelected = false;
            this.tBtn_Cancel.IsSelectedBtn = false;
            this.tBtn_Cancel.IsSingleSelectedBtn = false;
            this.tBtn_Cancel.Location = new System.Drawing.Point(168, 3);
            this.tBtn_Cancel.Name = "tBtn_Cancel";
            this.tBtn_Cancel.Size = new System.Drawing.Size(21, 21);
            this.tBtn_Cancel.TabIndex = 5;
            // 
            // tBtn_Text
            // 
            this.tBtn_Text.BtnImage = global::_SCREEN_CAPTURE.Properties.Resources.text;
            this.tBtn_Text.IsSelected = false;
            this.tBtn_Text.IsSelectedBtn = true;
            this.tBtn_Text.IsSingleSelectedBtn = false;
            this.tBtn_Text.Location = new System.Drawing.Point(123, 3);
            this.tBtn_Text.Name = "tBtn_Text";
            this.tBtn_Text.Size = new System.Drawing.Size(21, 21);
            this.tBtn_Text.TabIndex = 4;
            // 
            // tBtn_Brush
            // 
            this.tBtn_Brush.BtnImage = global::_SCREEN_CAPTURE.Properties.Resources.brush;
            this.tBtn_Brush.IsSelected = false;
            this.tBtn_Brush.IsSelectedBtn = true;
            this.tBtn_Brush.IsSingleSelectedBtn = false;
            this.tBtn_Brush.Location = new System.Drawing.Point(93, 3);
            this.tBtn_Brush.Name = "tBtn_Brush";
            this.tBtn_Brush.Size = new System.Drawing.Size(21, 21);
            this.tBtn_Brush.TabIndex = 3;
            // 
            // tBtn_Arrow
            // 
            this.tBtn_Arrow.BtnImage = global::_SCREEN_CAPTURE.Properties.Resources.arrow;
            this.tBtn_Arrow.IsSelected = false;
            this.tBtn_Arrow.IsSelectedBtn = true;
            this.tBtn_Arrow.IsSingleSelectedBtn = false;
            this.tBtn_Arrow.Location = new System.Drawing.Point(63, 3);
            this.tBtn_Arrow.Name = "tBtn_Arrow";
            this.tBtn_Arrow.Size = new System.Drawing.Size(21, 21);
            this.tBtn_Arrow.TabIndex = 2;
            // 
            // tBtn_Ellipse
            // 
            this.tBtn_Ellipse.BtnImage = global::_SCREEN_CAPTURE.Properties.Resources.ellips;
            this.tBtn_Ellipse.IsSelected = false;
            this.tBtn_Ellipse.IsSelectedBtn = true;
            this.tBtn_Ellipse.IsSingleSelectedBtn = false;
            this.tBtn_Ellipse.Location = new System.Drawing.Point(33, 3);
            this.tBtn_Ellipse.Name = "tBtn_Ellipse";
            this.tBtn_Ellipse.Size = new System.Drawing.Size(21, 21);
            this.tBtn_Ellipse.TabIndex = 1;
            // 
            // tBtn_Rect
            // 
            this.tBtn_Rect.BtnImage = global::_SCREEN_CAPTURE.Properties.Resources.rect;
            this.tBtn_Rect.IsSelected = false;
            this.tBtn_Rect.IsSelectedBtn = true;
            this.tBtn_Rect.IsSingleSelectedBtn = false;
            this.tBtn_Rect.Location = new System.Drawing.Point(3, 3);
            this.tBtn_Rect.Name = "tBtn_Rect";
            this.tBtn_Rect.Size = new System.Drawing.Size(21, 21);
            this.tBtn_Rect.TabIndex = 0;
            // 
            // FrmCapture2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "FrmCapture2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmCapture2";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCapture2_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmCapture2_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmCapture2_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pin在桌面ToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private ToolButton toolButton5;
        private ToolButton toolButton4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ToolButton tBtn_Finish;
        private ToolButton tBtn_Close;
        private ToolButton tBtn_Save;
        private ToolButton tBtn_Cancel;
        private ToolButton tBtn_Text;
        private ToolButton tBtn_Brush;
        private ToolButton tBtn_Arrow;
        private ToolButton tBtn_Ellipse;
        private ToolButton tBtn_Rect;
    }
}
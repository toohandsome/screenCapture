using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace _SCREEN_CAPTURE
{
    public class Gvar
    {
        private static int s_width = 0;
        private static int s_height = 0;

        public static string orc_token = "";

        public static Point pin_location;

        public static bool start_captrue = false;


        public static Bitmap getScreen() {

            Bitmap bmp = new Bitmap(getSize().Width,
                       getSize().Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(0, 0, 0, 0, bmp.Size);               
            }
           return bmp;

        }

        public static Size getSize() {

            if (s_width == 0 && s_height == 0) {
                GetResolving(ref s_width, ref s_height);
            }
            return new Size(s_width,s_height);
        }

        #region Dll引用
        [DllImport("User32.dll", EntryPoint = "GetDC")]
        private extern static IntPtr GetDC(IntPtr hWnd);

        [DllImport("User32.dll", EntryPoint = "ReleaseDC")]
        private extern static int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        public static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        [DllImport("User32.dll")]
        public static extern int GetSystemMetrics(int hWnd);

        const int DESKTOPVERTRES = 117;
        const int DESKTOPHORZRES = 118;
         
        #endregion
        private static void GetResolving(ref int width, ref int height)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            width = GetDeviceCaps(hdc, DESKTOPHORZRES);
            height = GetDeviceCaps(hdc, DESKTOPVERTRES);
            ReleaseDC(IntPtr.Zero, hdc);
        }

        public static unsafe Bitmap imgColorBrightness(Bitmap src, int light, int x, int y, int width, int height)
        {
            Console.WriteLine("light: " + light);
            if (light<0 || light>255) {
                return src;
            }
            Bitmap m_bmpDark = new Bitmap(src);
            using (Graphics g = Graphics.FromImage(m_bmpDark))
            {
                SolidBrush sb = new SolidBrush(Color.FromArgb(light, 0, 0, 0));
                //g.FillRectangle(sb, 0, 0, m_bmpDark.Width, m_bmpDark.Height);
                g.FillRectangle(sb, x, y, width, height);
                sb.Dispose();
            }
            return m_bmpDark;
        }
        public static Bitmap BrightnessP(Bitmap a, int v)
        {
            System.Drawing.Imaging.BitmapData bmpData = a.LockBits(new Rectangle(0, 0, a.Width, a.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            int bytes = a.Width * a.Height * 3;
            IntPtr ptr = bmpData.Scan0;
            int stride = bmpData.Stride;
            unsafe
            {
                byte* p = (byte*)ptr;
                int temp;
                for (int j = 0; j < a.Height; j++)
                {
                    for (int i = 0; i < a.Width * 3; i++, p++)
                    {
                        temp = (int)(p[0] + v);
                        temp = (temp > 255) ? 255 : temp < 0 ? 0 : temp;
                        p[0] = (byte)temp;
                    }
                    p += stride - a.Width * 3;
                }
            }
            a.UnlockBits(bmpData);
            return a;
        }


        public static string GetTimeString()
        {
            DateTime time = DateTime.Now;
            return time.Date.ToShortDateString().Replace("/", "") + "_" +
                time.ToLongTimeString().Replace(":", "");
        }

    }

}

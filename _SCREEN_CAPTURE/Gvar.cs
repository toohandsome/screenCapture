using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace _SCREEN_CAPTURE
{
    public class Gvar
    {
        private static int s_width = 0;
        private static int s_height = 0;


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
    }

}

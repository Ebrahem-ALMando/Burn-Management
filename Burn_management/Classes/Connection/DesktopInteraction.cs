using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Burn_management.Classes.Connection
{
    public class DesktopInteraction
    {
        private const uint SPI_SETDESKWALLPAPER = 0x0014;
        private const uint SPI_GETDESKWALLPAPER = 0x0073;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(uint uAction, int uParam, string lpvParam, int fuWinIni);

        /* public static void DisableGUI()
         {
             // تعطيل الخلفية والأيقونات على سطح المكتب
             SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, Properties.Resources, 0);
         }

         public static void EnableGUI()
         {
             // استعادة الخلفية والأيقونات على سطح المكتب
             SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, "C:\\Path\\To\\Your\\NormalWallpaper.jpg", 0);
         }*/
    }


    public class TaskbarInteraction
    {
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string className, string windowName);

        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

        public static void HideTaskbar()
        {
            IntPtr taskbarHandle = FindWindow("Shell_TrayWnd", "");
            ShowWindow(taskbarHandle, SW_HIDE);
        }

        public static void ShowTaskbar()
        {
            IntPtr taskbarHandle = FindWindow("Shell_TrayWnd", "");
            ShowWindow(taskbarHandle, SW_SHOW);
        }
    }
    public class KeyboardInteraction
    {
        private const int KEYEVENTF_KEYUP = 0x0002;
        private const int VK_LWIN = 0x5B; // رمز زر الويندوز الأيسر

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        public static void DisableWinKey()
        {
            keybd_event((byte)VK_LWIN, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
        }

        public static void EnableWinKey()
        {
            keybd_event((byte)VK_LWIN, 0, 0, UIntPtr.Zero);
        }
    }

}

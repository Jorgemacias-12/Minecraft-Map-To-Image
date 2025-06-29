using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;

namespace NBTMap_Explorer.Helpers
{
    public class SystemWindowBase : Window
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_CLOSE = 0xF060;
        private const int SC_MINIMIZE = 0xF020;
        private const int SC_MAXIMIZE = 0xF030;
        private const int SC_RESTORE = 0xF120;
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCAPTION = 0x0002;
        private const int COORD_BIT_MASK = 0xFFFF;
        private const int COORD_SHIFT = 16;
        private const int TOPBAR_HITTEST_HEIGHT = 32;

        public SystemWindowBase()
        {
            WindowStyle = WindowStyle.None;
            AllowsTransparency = false;

            SourceInitialized += (_, _) =>
            {
                var hwnd = new WindowInteropHelper(this).Handle;

                HwndSource source = HwndSource.FromHwnd(hwnd);
            };
        }

        private IntPtr GetHwnd()
        {
            return new WindowInteropHelper(this).Handle;
        }

        private void ToggleMaximize()
        {
            var hwnd = GetHwnd();
            var command = WindowState == WindowState.Maximized ? SC_RESTORE : SC_MAXIMIZE;

            SendMessage(hwnd, WM_SYSCOMMAND, new IntPtr(command), IntPtr.Zero);
        }

        protected void HandleTopBarDrag(MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (e.ClickCount == 2)
                {
                    ToggleMaximize();
                }
                else
                {
                    DragMove();
                }
            }
        }

        protected void Minimize() => SendMessage(GetHwnd(), WM_SYSCOMMAND, (IntPtr)SC_MINIMIZE, IntPtr.Zero);
        protected void CloseWindow() => SendMessage(GetHwnd(), WM_SYSCOMMAND, (IntPtr)SC_CLOSE, IntPtr.Zero);

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg == WM_NCHITTEST)
            {
                int raw = lParam.ToInt32();

                int screenX = raw & COORD_BIT_MASK;
                int screenY = raw >> COORD_SHIFT;

                Point mousePos = PointFromScreen(new Point(screenX, screenY));

                if (mousePos.Y <= TOPBAR_HITTEST_HEIGHT)
                {
                    handled = true;

                    return new nint(HTCAPTION);
                }
            }

            return IntPtr.Zero; 
        }
    }
}

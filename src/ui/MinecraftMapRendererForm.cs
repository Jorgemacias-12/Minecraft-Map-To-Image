using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer
{
    public partial class MinecraftMapRendererForm : Form
    {
        #region InteropConstants
        private const int WM_SYSCOMMAND = 0x112;
        private const int MOUSE_MOVE = 0xF012;
        private const int WM_LPARAM = 0;
        #endregion

        #region Form Constants
        private const int TOOLBAR_WIDTH = 100;
        private const int TOOLBAR_HEIGHT = 100;
        #endregion

        #region Form variables
        private bool isMaximized = false;
        private Point NormalLocation;
        private Point MaximizedLocation;

        #endregion

        public MinecraftMapRendererForm()
        {
            InitializeComponent();
        }
        
        #region FormMouseMovement

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void Pnl_Topbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, WM_LPARAM);
        }

        private void Lbl_Title_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, WM_LPARAM);
        }

        private void Pnl_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, WM_LPARAM);
        }

        #endregion

        #region FormControls
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_resize_Click(object sender, EventArgs e)
        {
            isMaximized = !isMaximized;

            Size = HandleWindowResize();
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region FormLoad
        private void MinecraftMapRendererForm_Load(object sender, EventArgs e)
        {
            MaximizedLocation = new Point(0,0);
            NormalLocation = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2); ;
        }
        #endregion

        #region Ui Util Functions
        private Size HandleWindowResize()
        {
            Rectangle WindowInitialSize;
            Rectangle WindowMaximizedSize;

            WindowInitialSize = Screen.PrimaryScreen.WorkingArea;
            WindowMaximizedSize = Screen.FromControl(this).Bounds;            

            Location = isMaximized ? MaximizedLocation : NormalLocation;

            if (isMaximized)
            {
                return new Size(WindowMaximizedSize.Width, WindowInitialSize.Height);
            }

            if(!isMaximized)
            {
                return new Size(MinimumSize.Width, MinimumSize.Height);
            }

            return new Size(0, 0);
        }
        #endregion
    }
}

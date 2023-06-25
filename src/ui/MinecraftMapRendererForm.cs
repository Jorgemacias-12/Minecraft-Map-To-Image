using System;
using Minecraft_Map_Renderer.src.logic;
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
        Rectangle WindowInitialSize;
        Rectangle WindowMaximizedSize;
        #endregion

        #region Form variables
        private bool isMaximized = false;
        #endregion

        #region Form 
        public MinecraftMapRendererForm()
        {
            InitializeComponent();
        }
        #endregion
        
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
            WindowInitialSize =  new Rectangle(Location.X, Location.Y, Width, Height);
            WindowMaximizedSize = Screen.PrimaryScreen.WorkingArea;
            MinecraftVersions MinecraftVersions = new MinecraftVersions();

            MessageBox.Show(Convert.ToString(MinecraftVersions.Versions.Count));
        }
        #endregion

        #region Ui Util Functions
        private Size HandleWindowResize()
        {
            if (isMaximized)
            {
                Location = new Point(0, 0);
                return new Size(WindowMaximizedSize.Width, WindowMaximizedSize.Height);
            }

            if(!isMaximized)
            {
                Location = new Point(WindowInitialSize.X, WindowInitialSize.Y);
                return new Size(WindowInitialSize.Width, WindowInitialSize.Height);
            }

            return new Size(0, 0);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer.src.ui.forms
{
    public partial class BaseForm : Form
    {
        #region InteropConstants
        private const int WM_SYSCOMMAND = 0x112;
        private const int MOUSE_MOVE = 0xF012;
        private const int WM_LPARAM = 0;
        private const int WM_FONTCHANGE = 0x1a;
        private const int HWND_BROADCAST = 0x1d;
        #endregion

        #region Form Constants
        Rectangle WindowInitialSize;
        Screen WindowMaximizedSize;
        #endregion

        #region Form variables
        private bool isMaximized = false;

        [Category("Behavior")]
        [Browsable(true)]
        [Description("Allows to hide the maximize/minimize button of the window")]
        public bool Maximize { get; set; }
        #endregion

        #region Base Form constructor
        public BaseForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events

        private void BaseForm_Load(object sender, EventArgs e)
        {
            WindowInitialSize = new Rectangle(Location.X, Location.Y, Width, Height);

            Tbl_Controls.ColumnStyles[1] = Maximize ? new ColumnStyle(SizeType.Percent, 33.3f) :
                                                      new ColumnStyle(SizeType.Absolute, 0);

            Btn_resize.Visible = Maximize;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wsmg, int wparam, int lparam);

        [DllImport("gdi32.dll", EntryPoint = "AddFontResourceW", SetLastError = true)]
        public static extern int AddFontResource(string lpFileName);

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

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_resize_Click(object sender, EventArgs e)
        {
            isMaximized = !isMaximized;

            WindowInitialSize.X = Location.X;
            WindowInitialSize.Y = Location.Y;

            Size = HandleWindowResize();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            if (Modal)
            {
                Dispose();
                return;
            }

            Application.Exit();
        }

        private void BaseForm_Move(object sender, EventArgs e)
        {
            if (WindowMaximizedSize != Screen.FromControl(this))
            {
                WindowMaximizedSize = Screen.FromControl(this);
            }
        }

        #endregion

        #region Form Utils Functions
        private Size HandleWindowResize()
        {
            Size _;

            _ = isMaximized ? new Size(WindowMaximizedSize.WorkingArea.Width, WindowMaximizedSize.WorkingArea.Height)
                            : new Size(WindowInitialSize.Width, WindowInitialSize.Height);

            if (!isMaximized)
            {
                Location = new Point(WindowMaximizedSize.WorkingArea.Left + (WindowMaximizedSize.WorkingArea.Width - WindowInitialSize.Width) / 2,
                                     (WindowMaximizedSize.WorkingArea.Height - WindowInitialSize.Height) / 2);
            }
            else
            {
                Location = new Point(WindowMaximizedSize.WorkingArea.X, WindowMaximizedSize.WorkingArea.Y);
            }

            return _;
        }
        #endregion
    }
}

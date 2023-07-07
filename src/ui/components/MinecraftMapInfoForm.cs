using Minecraft_Map_Renderer.src.logic;
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

namespace Minecraft_Map_Renderer.src.ui.components
{
    public partial class MinecraftMapInfoForm : Form
    {
        #region Class Variables
        private MinecraftMap Map;
        #endregion 

        #region InteropConstants
        private const int WM_SYSCOMMAND = 0x112;
        private const int MOUSE_MOVE = 0xF012;
        private const int WM_LPARAM = 0;
        #endregion

        #region Form
        public MinecraftMapInfoForm(MinecraftMap map)
        {
            Map = map;

            InitializeComponent();

            HandleShowData();
        }
        #endregion

        #region FormMouseMovement

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void Pnl_TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, WM_LPARAM);
        }

        private void Lbl_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, WM_LPARAM);
        }
        #endregion

        #region FromControl
        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_resize_Click(object sender, EventArgs e)
        {

        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        #endregion

        private void HandleShowData()
        {
            Pnl_MapView.BackgroundImage = Map.Image;
            Pnl_MapView.BackgroundImageLayout = ImageLayout.Stretch;

            Lbl_Name.Text = Map.Name;
            Tbx_Locked.Text = Map.Locked.ToString();
            Tbx_Scale.Text = Map.Scale.ToString();
            Tbx_Width.Text = Map.Width.ToString();
            Tbx_Height.Text = Map.Height.ToString();
            Tbx_TrackingPosition.Text = Map.TrackingPosition.ToString();
            Tbx_XPosition.Text = Map.XCenter.ToString();
            Tbx_ZPosition.Text = Map.ZCenter.ToString();
            Tbx_Dimension.Text = Map.Dimension.ToString(); 
        }
    }
}

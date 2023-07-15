using Minecraft_Map_Renderer.src.logic;
using Minecraft_Map_Renderer.src.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer.src.ui.components
{
    public partial class MinecraftMapForm : Form
    {
        #region Class variales
        private MinecraftMap Map;
        #endregion

        #region Interop constants
        private const int WM_SYSCOMMAND = 0x112;
        private const int MOUSE_MOVE = 0xF012;
        private const int WM_LPARAM = 0;
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

        #region Form constructor
        public MinecraftMapForm(MinecraftMap map)
        {
            Map = map;

            InitializeComponent();

            HandleComponentsBorder();
        }
        #endregion

        #region FromControl
        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        #endregion

        private void HandleComponentsBorder()
        {
            Pnl_InfoContainer.Border.AllSize = 0;

            Pnl_MapView.Border.AllSize = 0;
            Pnl_MapView.Border.RightSize = 2;
            Pnl_MapView.Border.AllColor = ColorTranslator.FromHtml("#6F746D");

            Pnl_ExportControls.Border.AllSize = 0;
            Pnl_ExportControls.Border.TopSize = 2;
            Pnl_ExportControls.Border.RightSize = 2;
            Pnl_ExportControls.Border.AllColor = ColorTranslator.FromHtml("#6F746D");

            Pnl_Dimension.Border.AllSize = 0;
            Pnl_Locked.Border.AllSize = 0;
            Pnl_Scale.Border.AllSize = 0;
            Pnl_TrackingPosition.Border.AllSize = 0;
            Pnl_UnlimitedTracking.Border.AllSize = 0;
            Pnl_XCenter.Border.AllSize = 0; 
            Pnl_ZCenter.Border.AllSize = 0;
            Pnl_Width.Border.AllSize = 0;
            Pnl_Height.Border.AllSize = 0;
        }

        private void MinecraftMapForm_Load(object sender, EventArgs e)
        {
            /*foreach(string codec in ImageFormats.Formats)
            {
                Cmb_ImageExtensions.Items.Add(codec);
            }
            */

            foreach (string fileNameExtension in ImageFormats.Formats.Keys)
            {
                Cmb_ImageExtensions.Items.Add(fileNameExtension);
            }

            Cmb_ImageExtensions.SelectedIndex = 0;

            Lbl_Name.Text = Map.Name;

            Pbx_MapImage.BackgroundImage = Map.Image;
            Pbx_MapImage.BackgroundImageLayout = ImageLayout.Stretch;

            Lbl_Dimension.Text = Map.Dimension;
            Lbl_Locked.Text += $" {Map.Locked}";
            Lbl_Scale.Text += $" {Map.Scale}";
            Lbl_TrackingPosition.Text += $" {Map.TrackingPosition}";
            Lbl_UnlimitedTracking.Text += $" {Map.UnlimitedTracking}";
            Lbl_XCenter.Text += $" {Map.XCenter}";
            Lbl_ZCenter.Text += $" {Map.ZCenter}";
            Lbl_Width.Text += $" {Map.Width}";
            Lbl_Height.Text += $" {Map.Height}";

            foreach(Control _ in Tlp_MapInfo.Controls)
            {
                _.BackColor = Color.FromArgb(52, 58, 64);
            }
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog _ = new SaveFileDialog()
            {
                Title = $"Export {Map.Name} as Image",
                AddExtension = true,
                FileName = $"{Map.Name}.{Cmb_ImageExtensions.Text}"
        };

            DialogResult result = _.ShowDialog();

            if (result != DialogResult.OK)
            {
                MessageBox.Show("Export operation was cancel by user", 
                                "Attention!", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                
                return;
            }

            // TODO: implement save with image extension
            // Map.Image.Save(FileName);
            // Map.Image.Save(FileName, );
            // Map.Image.Save(_.FileName,);

            Map.Image.Save(_.FileName,
                           ImageFormats.Formats[Cmb_ImageExtensions.Text]);

            Process photoViewer = new Process();

            photoViewer.StartInfo.FileName = _.FileName;
            photoViewer.StartInfo.Arguments = _.FileName;
            photoViewer.Start();
        }
    }
}

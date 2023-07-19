using Minecraft_Map_Renderer.src.logic;
using Minecraft_Map_Renderer.src.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer.src.ui.forms
{
    public partial class MinecraftMapViewForm : BaseForm
    {
        #region Form Variables
        private MinecraftMap Map;
        #endregion

        public MinecraftMapViewForm()
        {
            InitializeComponent();
        }

        public MinecraftMapViewForm(MinecraftMap map)
        {
            InitializeComponent();

            this.Map = map;
        }

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

        private void HandleGetImageExtensions()
        {
            foreach (string fileNameExtension in ImageFormats.Formats.Keys)
            {
                Cmb_ImageExtensions.Items.Add(fileNameExtension);
            }
        }

        private void HandleShowMapData()
        {
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

            foreach (Control _ in Tlp_MapInfo.Controls)
            {
                _.BackColor = Color.FromArgb(52, 58, 64);
            }
        }

        private void MinecraftMapViewForm_Load(object sender, EventArgs e)
        {
            HandleComponentsBorder();

            HandleGetImageExtensions();

            HandleShowMapData();
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

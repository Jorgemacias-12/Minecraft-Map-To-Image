using Minecraft_Map_Renderer.src.logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer.src.ui.components
{
    public partial class Dashboard : UserControl
    {
        #region Class Variables
        private readonly MinecraftSaves minecraftSaves = MinecraftSaves.Instance;
        public event EventHandler<EventArgs> ButtonClicked;
        #endregion

        private Color ButtonHover = Color.FromArgb(52, 58, 64);
        private Color ButtonClick = Color.FromArgb(73, 80, 87);
        private Color ButtonSelected = Color.FromArgb(74, 95, 236);
        private const int PADDING = 10;

        public Dashboard()
        {
            InitializeComponent();
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            await MinecraftSaves.Instance.ReadSaves();

            foreach(MinecraftSave Save in minecraftSaves.Saves)
            {
                MinecraftSaveView view = new MinecraftSaveView(Save.SplashIcon, Save.Name)
                {
                    Width = Flp_SavesContainer.Width - 45,
                    Height = 64,
                    BorderRadius = 5
                };

                view.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
                view.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
                view.TextAlign = ContentAlignment.MiddleRight;
                view.Margin = new Padding(10, 5, 10, 5);
                view.Padding = new Padding(PADDING, 0, 0, 0);

                view.Click += MinecraftSaveViewClicked;

                Flp_SavesContainer.Controls.Add(view);
            }
        }

        private void HandleVisualIndicator(object sender)
        {
            Button _ = sender as Button;

            foreach(Control control in Flp_SavesContainer.Controls)
            {
                if (control is Button)
                {
                    Button btn = control as Button;

                    btn.BackColor = Color.Transparent;
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
                }
            }

            _.FlatAppearance.MouseOverBackColor = ButtonSelected;
            _.BackColor = ButtonSelected;
        }

        private void MinecraftSaveViewClicked(object sender, EventArgs e)
        {
            HandleVisualIndicator(sender);
            ButtonClicked.Invoke(sender, e);
        }

        private void Flp_SavesContainer_Resize(object sender, EventArgs e)
        {
            foreach (Control control in Flp_SavesContainer.Controls)
            {
                control.Width = Flp_SavesContainer.Width - 45;
            }
        }

        private async void BtnReload_Click(object sender, EventArgs e)
        {
            // Reload Maps and saves
            await MinecraftSaves.Instance.ReadSaves();
        }

        private void Btn_config_Click(object sender, EventArgs e)
        {
            // Open config form
        }
    }
}

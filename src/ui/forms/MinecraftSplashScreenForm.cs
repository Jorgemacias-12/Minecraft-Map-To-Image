using Minecraft_Map_Renderer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer.src.ui.forms
{
    public partial class MinecraftSplashScreenForm : Form
    {
        private MinecraftEditionSelectorForm form;
        private int progressCurrentValue;
        private readonly int progressStep = 1;
        private readonly System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private List<Image> Backgrounds = new List<Image>()
        {
            Resources.blackstone_block,
            Resources.obsidian_block,
            Resources.netherrack_block,
            Resources.gravel_block,
            Resources.coal_block,
            Resources.deepslate_block,
            Resources.netherite_block,
            Resources.emerald_block,
            Resources.mud_block,
        };

        private List<Color> Colors = new List<Color>()
        {
            Color.FromArgb(67, 97, 238),
            Color.FromArgb(252, 81, 48),
            Color.FromArgb(81, 158, 138),
            Color.FromArgb(10, 10, 12)
        };

        public static bool IsFormOpen(FormCollection Forms, Type formType)
        {
            return Application.OpenForms.Cast<Form>().Any(openForm => openForm.GetType() == formType);
        }

        public MinecraftSplashScreenForm()
        {
            InitializeComponent();
        }

        private void MinecraftSplashForm_Load(object sender, EventArgs e)
        { 
            SplashScreenLoad();
            ApplyRandomBackground();
        }

        private void ApplyRandomBackground()
        {
            Random r = new Random();

            int index = r.Next(Backgrounds.Count);

            BackgroundImage = Backgrounds[index];

            index = r.Next(Colors.Count);

            Lbl_Title.BackColor = Colors[index];
            Lbl_LoadingCaption.ForeColor = Colors[index];
        }

        private void SplashScreenLoad()
        {
            Pgb_SplashScreen.Minimum = 0;
            Pgb_SplashScreen.Maximum = 100;

            progressCurrentValue = Pgb_SplashScreen.Value;

            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsFormOpen(Application.OpenForms, typeof(MinecraftEditionMapViewerForm)) &&
                form is null)
            {
                progressCurrentValue += progressStep;
                Pgb_SplashScreen.Value = progressCurrentValue;

                Pgb_SplashScreen.Refresh();

                form = new MinecraftEditionSelectorForm();

                Pgb_SplashScreen.Value = Pgb_SplashScreen.Maximum;

                await Task.Delay(500);

                form.Show();
                
                Close();
            }
        }
    }
}

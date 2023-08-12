using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_Renderer.src.ui.components
{
    public class JProgressBar : ProgressBar
    {
        private Color _ProgressColor = Color.Green;
        private Color _BackgroundColor = Color.White;
        private int _BorderRadius = 0;


        [Category("Appearance")]
        [Description("The color of the progress bar's filled portion.")]
        [Browsable(true)]
        public Color ProgressColor
        {
            get
            {
                return _ProgressColor;
            }

            set
            {
                _ProgressColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("The background color of the progress bar's unfilled portion.")]
        [Browsable(true)]
        public Color BackgroundColor
        {
            get
            {
                return _BackgroundColor;
            }
            set
            {
                _BackgroundColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("The corner radius for the control's border.")]
        [Browsable(true)]
        public int BorderRadius
        {
            get
            {
                return _BorderRadius;
            }
            set
            {

                _BorderRadius = value;
                Invalidate();
            }
        }

        public JProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle filledRect = ClientRectangle;
            filledRect.Width = (int)(filledRect.Width * ((double)Value / Maximum));

            base.OnPaint(e);

            using (SolidBrush filledBrush = new SolidBrush(ForeColor))
            {
                e.Graphics.FillRectangle(filledBrush, filledRect);
            }

            Rectangle remainingRect = ClientRectangle;
            remainingRect.X = filledRect.Right;
            remainingRect.Width = ClientRectangle.Right - filledRect.Right;

            using (SolidBrush remainingBrush = new SolidBrush(BackgroundColor))
            {
                e.Graphics.FillRectangle(remainingBrush, remainingRect);
            }
        }
    }
}

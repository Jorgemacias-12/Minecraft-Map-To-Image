using Minecraft_Map_Renderer.src.ui.components;

namespace Minecraft_Map_Renderer.src.ui.forms
{
    partial class MinecraftSplashScreenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinecraftSplashScreenForm));
            this.Pnl_bottom = new System.Windows.Forms.Panel();
            this.Lbl_LoadingCaption = new System.Windows.Forms.Label();
            this.Pgb_SplashScreen = new Minecraft_Map_Renderer.src.ui.components.JProgressBar();
            this.Pnl_Top = new System.Windows.Forms.Panel();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Pnl_bottom.SuspendLayout();
            this.Pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_bottom
            // 
            this.Pnl_bottom.AutoSize = true;
            this.Pnl_bottom.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_bottom.Controls.Add(this.Lbl_LoadingCaption);
            this.Pnl_bottom.Controls.Add(this.Pgb_SplashScreen);
            this.Pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_bottom.Location = new System.Drawing.Point(0, 220);
            this.Pnl_bottom.Name = "Pnl_bottom";
            this.Pnl_bottom.Padding = new System.Windows.Forms.Padding(10);
            this.Pnl_bottom.Size = new System.Drawing.Size(620, 70);
            this.Pnl_bottom.TabIndex = 2;
            // 
            // Lbl_LoadingCaption
            // 
            this.Lbl_LoadingCaption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_LoadingCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_LoadingCaption.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_LoadingCaption.Location = new System.Drawing.Point(10, 10);
            this.Lbl_LoadingCaption.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_LoadingCaption.Name = "Lbl_LoadingCaption";
            this.Lbl_LoadingCaption.Size = new System.Drawing.Size(600, 27);
            this.Lbl_LoadingCaption.TabIndex = 1;
            this.Lbl_LoadingCaption.Text = "Cargando...";
            // 
            // Pgb_SplashScreen
            // 
            this.Pgb_SplashScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Pgb_SplashScreen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Pgb_SplashScreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pgb_SplashScreen.Location = new System.Drawing.Point(10, 37);
            this.Pgb_SplashScreen.Name = "Pgb_SplashScreen";
            this.Pgb_SplashScreen.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.Pgb_SplashScreen.Size = new System.Drawing.Size(600, 23);
            this.Pgb_SplashScreen.TabIndex = 0;
            // 
            // Pnl_Top
            // 
            this.Pnl_Top.AutoSize = true;
            this.Pnl_Top.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_Top.Controls.Add(this.Lbl_Title);
            this.Pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Top.Location = new System.Drawing.Point(0, 10);
            this.Pnl_Top.Name = "Pnl_Top";
            this.Pnl_Top.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Pnl_Top.Size = new System.Drawing.Size(620, 34);
            this.Pnl_Top.TabIndex = 3;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(10, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(600, 34);
            this.Lbl_Title.TabIndex = 2;
            this.Lbl_Title.Text = "Minecraft Map Exporter";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinecraftSplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(620, 300);
            this.ControlBox = false;
            this.Controls.Add(this.Pnl_Top);
            this.Controls.Add(this.Pnl_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MinecraftSplashScreenForm";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MinecraftSplashForm_Load);
            this.Pnl_bottom.ResumeLayout(false);
            this.Pnl_Top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_bottom;
        private JProgressBar Pgb_SplashScreen;
        private System.Windows.Forms.Panel Pnl_Top;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_LoadingCaption;
    }
}
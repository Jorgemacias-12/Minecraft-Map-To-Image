﻿namespace Minecraft_Map_Renderer.src.ui.forms
{
    partial class MinecraftMapToImageForm
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
            this.Spc_Container = new System.Windows.Forms.SplitContainer();
            this.Dashboard = new Minecraft_Map_Renderer.src.ui.components.Dashboard();
            this.MapsView = new Minecraft_Map_Renderer.src.ui.components.MinecraftMapsView();
            this.Pnl_Topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Icon)).BeginInit();
            this.Pnl_MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spc_Container)).BeginInit();
            this.Spc_Container.Panel1.SuspendLayout();
            this.Spc_Container.Panel2.SuspendLayout();
            this.Spc_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Topbar
            // 
            this.Pnl_Topbar.Size = new System.Drawing.Size(800, 40);
            // 
            // Pnl_MainContainer
            // 
            this.Pnl_MainContainer.Controls.Add(this.Spc_Container);
            this.Pnl_MainContainer.Size = new System.Drawing.Size(800, 600);
            this.Pnl_MainContainer.Controls.SetChildIndex(this.Pnl_Topbar, 0);
            this.Pnl_MainContainer.Controls.SetChildIndex(this.Spc_Container, 0);
            // 
            // Spc_Container
            // 
            this.Spc_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Spc_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spc_Container.Location = new System.Drawing.Point(0, 40);
            this.Spc_Container.Name = "Spc_Container";
            // 
            // Spc_Container.Panel1
            // 
            this.Spc_Container.Panel1.Controls.Add(this.Dashboard);
            // 
            // Spc_Container.Panel2
            // 
            this.Spc_Container.Panel2.Controls.Add(this.MapsView);
            this.Spc_Container.Size = new System.Drawing.Size(800, 560);
            this.Spc_Container.SplitterDistance = 266;
            this.Spc_Container.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(266, 560);
            this.Dashboard.TabIndex = 0;
            // 
            // MapsView
            // 
            this.MapsView.AutoScroll = true;
            this.MapsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.MapsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapsView.Location = new System.Drawing.Point(0, 0);
            this.MapsView.Name = "MapsView";
            this.MapsView.Padding = new System.Windows.Forms.Padding(20);
            this.MapsView.Save = null;
            this.MapsView.Size = new System.Drawing.Size(530, 560);
            this.MapsView.TabIndex = 0;
            // 
            // MinecraftMapToImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ForeColor = System.Drawing.Color.White;
            this.Maximize = true;
            this.Name = "MinecraftMapToImageForm";
            this.Text = "MinecraftMapToImageForm";
            this.Load += new System.EventHandler(this.MinecraftMapToImageForm_Load);
            this.Pnl_Topbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Icon)).EndInit();
            this.Pnl_MainContainer.ResumeLayout(false);
            this.Spc_Container.Panel1.ResumeLayout(false);
            this.Spc_Container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Spc_Container)).EndInit();
            this.Spc_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Spc_Container;
        private components.Dashboard Dashboard;
        private components.MinecraftMapsView MapsView;
    }
}
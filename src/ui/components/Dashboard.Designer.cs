namespace Minecraft_Map_Renderer.src.ui.components
{
    partial class Dashboard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Lbl_title = new System.Windows.Forms.Label();
            this.Flp_SavesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.Flp_Info = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_config = new System.Windows.Forms.Button();
            this.BtnReload = new System.Windows.Forms.Button();
            this.Flp_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_title
            // 
            this.Lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(232)))), ((int)(((byte)(126)))));
            this.Lbl_title.Location = new System.Drawing.Point(0, 0);
            this.Lbl_title.Name = "Lbl_title";
            this.Lbl_title.Size = new System.Drawing.Size(313, 46);
            this.Lbl_title.TabIndex = 0;
            this.Lbl_title.Text = "Minecraft Saves";
            this.Lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Flp_SavesContainer
            // 
            this.Flp_SavesContainer.AutoScroll = true;
            this.Flp_SavesContainer.BackColor = System.Drawing.Color.Transparent;
            this.Flp_SavesContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Flp_SavesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp_SavesContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Flp_SavesContainer.Location = new System.Drawing.Point(0, 46);
            this.Flp_SavesContainer.Margin = new System.Windows.Forms.Padding(0);
            this.Flp_SavesContainer.Name = "Flp_SavesContainer";
            this.Flp_SavesContainer.Padding = new System.Windows.Forms.Padding(10);
            this.Flp_SavesContainer.Size = new System.Drawing.Size(313, 580);
            this.Flp_SavesContainer.TabIndex = 1;
            this.Flp_SavesContainer.WrapContents = false;
            this.Flp_SavesContainer.Resize += new System.EventHandler(this.Flp_SavesContainer_Resize);
            // 
            // Flp_Info
            // 
            this.Flp_Info.BackColor = System.Drawing.Color.Transparent;
            this.Flp_Info.Controls.Add(this.Btn_config);
            this.Flp_Info.Controls.Add(this.BtnReload);
            this.Flp_Info.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Flp_Info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Flp_Info.Location = new System.Drawing.Point(0, 580);
            this.Flp_Info.Name = "Flp_Info";
            this.Flp_Info.Size = new System.Drawing.Size(313, 46);
            this.Flp_Info.TabIndex = 2;
            // 
            // Btn_config
            // 
            this.Btn_config.AutoSize = true;
            this.Btn_config.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_config.BackgroundImage")));
            this.Btn_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_config.FlatAppearance.BorderSize = 0;
            this.Btn_config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(139)))), ((int)(((byte)(155)))));
            this.Btn_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_config.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_config.Location = new System.Drawing.Point(3, 3);
            this.Btn_config.Name = "Btn_config";
            this.Btn_config.Size = new System.Drawing.Size(50, 43);
            this.Btn_config.TabIndex = 0;
            this.Btn_config.UseVisualStyleBackColor = true;
            this.Btn_config.Click += new System.EventHandler(this.Btn_config_Click);
            // 
            // BtnReload
            // 
            this.BtnReload.AutoSize = true;
            this.BtnReload.BackgroundImage = global::Minecraft_Map_Renderer.Properties.Resources.reload_png;
            this.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnReload.FlatAppearance.BorderSize = 0;
            this.BtnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(139)))), ((int)(((byte)(155)))));
            this.BtnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReload.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnReload.Location = new System.Drawing.Point(59, 3);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(53, 40);
            this.BtnReload.TabIndex = 1;
            this.BtnReload.UseVisualStyleBackColor = true;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.Flp_Info);
            this.Controls.Add(this.Flp_SavesContainer);
            this.Controls.Add(this.Lbl_title);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(313, 626);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Flp_Info.ResumeLayout(false);
            this.Flp_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_title;
        private System.Windows.Forms.FlowLayoutPanel Flp_SavesContainer;
        private System.Windows.Forms.FlowLayoutPanel Flp_Info;
        private System.Windows.Forms.Button Btn_config;
        private System.Windows.Forms.Button BtnReload;
    }
}

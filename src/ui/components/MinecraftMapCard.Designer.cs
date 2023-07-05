namespace Minecraft_Map_Renderer.src.ui.components
{
    partial class MinecraftMapCard
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
            this.Lbl_MapName = new System.Windows.Forms.Label();
            this.Pbx_MapPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_MapPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_MapName
            // 
            this.Lbl_MapName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_MapName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MapName.Location = new System.Drawing.Point(0, 125);
            this.Lbl_MapName.Name = "Lbl_MapName";
            this.Lbl_MapName.Size = new System.Drawing.Size(128, 24);
            this.Lbl_MapName.TabIndex = 0;
            this.Lbl_MapName.Text = "Texto";
            this.Lbl_MapName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pbx_MapPreview
            // 
            this.Pbx_MapPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pbx_MapPreview.Location = new System.Drawing.Point(0, 0);
            this.Pbx_MapPreview.Name = "Pbx_MapPreview";
            this.Pbx_MapPreview.Size = new System.Drawing.Size(128, 125);
            this.Pbx_MapPreview.TabIndex = 1;
            this.Pbx_MapPreview.TabStop = false;
            // 
            // MinecraftMapCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pbx_MapPreview);
            this.Controls.Add(this.Lbl_MapName);
            this.Name = "MinecraftMapCard";
            this.Size = new System.Drawing.Size(128, 149);
            this.Load += new System.EventHandler(this.MinecraftMapCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_MapPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_MapName;
        private System.Windows.Forms.PictureBox Pbx_MapPreview;
    }
}

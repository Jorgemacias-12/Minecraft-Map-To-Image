namespace Minecraft_Map_Renderer.src.ui.forms
{
    partial class MinecraftEditionView
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
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Pnl_Controls = new System.Windows.Forms.Panel();
            this.Btn_Select = new System.Windows.Forms.Button();
            this.Pnl_Image = new System.Windows.Forms.Panel();
            this.Pbx_Edition = new System.Windows.Forms.PictureBox();
            this.Pnl_Controls.SuspendLayout();
            this.Pnl_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Edition)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(81)))), ((int)(((byte)(48)))));
            this.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(438, 44);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Edition name here";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Controls
            // 
            this.Pnl_Controls.Controls.Add(this.Btn_Select);
            this.Pnl_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Controls.Location = new System.Drawing.Point(0, 370);
            this.Pnl_Controls.Name = "Pnl_Controls";
            this.Pnl_Controls.Padding = new System.Windows.Forms.Padding(10);
            this.Pnl_Controls.Size = new System.Drawing.Size(438, 49);
            this.Pnl_Controls.TabIndex = 1;
            // 
            // Btn_Select
            // 
            this.Btn_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(189)))), ((int)(((byte)(143)))));
            this.Btn_Select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Select.FlatAppearance.BorderSize = 0;
            this.Btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Select.ForeColor = System.Drawing.Color.White;
            this.Btn_Select.Location = new System.Drawing.Point(10, 10);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(418, 29);
            this.Btn_Select.TabIndex = 0;
            this.Btn_Select.Text = "Seleccionar";
            this.Btn_Select.UseVisualStyleBackColor = false;
            this.Btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
            // 
            // Pnl_Image
            // 
            this.Pnl_Image.Controls.Add(this.Pbx_Edition);
            this.Pnl_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Image.Location = new System.Drawing.Point(0, 44);
            this.Pnl_Image.Name = "Pnl_Image";
            this.Pnl_Image.Padding = new System.Windows.Forms.Padding(10);
            this.Pnl_Image.Size = new System.Drawing.Size(438, 326);
            this.Pnl_Image.TabIndex = 2;
            // 
            // Pbx_Edition
            // 
            this.Pbx_Edition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pbx_Edition.Location = new System.Drawing.Point(10, 10);
            this.Pbx_Edition.Name = "Pbx_Edition";
            this.Pbx_Edition.Size = new System.Drawing.Size(418, 306);
            this.Pbx_Edition.TabIndex = 0;
            this.Pbx_Edition.TabStop = false;
            // 
            // MinecraftEditionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.Pnl_Image);
            this.Controls.Add(this.Pnl_Controls);
            this.Controls.Add(this.Lbl_Title);
            this.Name = "MinecraftEditionView";
            this.Size = new System.Drawing.Size(438, 419);
            this.Pnl_Controls.ResumeLayout(false);
            this.Pnl_Image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Edition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Panel Pnl_Controls;
        private System.Windows.Forms.Panel Pnl_Image;
        private System.Windows.Forms.PictureBox Pbx_Edition;
        private System.Windows.Forms.Button Btn_Select;
    }
}

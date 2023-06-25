namespace Minecraft_Map_Renderer
{
    partial class MinecraftMapRendererForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_Topbar = new System.Windows.Forms.Panel();
            this.Btn_resize = new System.Windows.Forms.Button();
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Pnl_Topbar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Topbar
            // 
            this.Pnl_Topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.Pnl_Topbar.Controls.Add(this.tableLayoutPanel1);
            this.Pnl_Topbar.Controls.Add(this.Lbl_Title);
            this.Pnl_Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Topbar.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Topbar.Name = "Pnl_Topbar";
            this.Pnl_Topbar.Size = new System.Drawing.Size(800, 48);
            this.Pnl_Topbar.TabIndex = 0;
            this.Pnl_Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Topbar_MouseDown);
            // 
            // Btn_resize
            // 
            this.Btn_resize.BackgroundImage = global::Minecraft_Map_Renderer.Properties.Resources.window_maximize_solid;
            this.Btn_resize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_resize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_resize.FlatAppearance.BorderSize = 0;
            this.Btn_resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_resize.Location = new System.Drawing.Point(69, 3);
            this.Btn_resize.Name = "Btn_resize";
            this.Btn_resize.Size = new System.Drawing.Size(60, 42);
            this.Btn_resize.TabIndex = 1;
            this.Btn_resize.UseVisualStyleBackColor = true;
            this.Btn_resize.Click += new System.EventHandler(this.Btn_resize_Click);
            // 
            // Btn_minimize
            // 
            this.Btn_minimize.BackgroundImage = global::Minecraft_Map_Renderer.Properties.Resources.minus_solid;
            this.Btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_minimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_minimize.FlatAppearance.BorderSize = 0;
            this.Btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimize.Location = new System.Drawing.Point(3, 3);
            this.Btn_minimize.Name = "Btn_minimize";
            this.Btn_minimize.Size = new System.Drawing.Size(60, 42);
            this.Btn_minimize.TabIndex = 2;
            this.Btn_minimize.UseVisualStyleBackColor = true;
            this.Btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Lbl_Title.Size = new System.Drawing.Size(262, 48);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Minecraft Map To Image";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lbl_Title_MouseMove);
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackgroundImage = global::Minecraft_Map_Renderer.Properties.Resources.xmark_solid;
            this.Btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_exit.FlatAppearance.BorderSize = 0;
            this.Btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.Btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.Location = new System.Drawing.Point(142, 3);
            this.Btn_exit.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Padding = new System.Windows.Forms.Padding(30);
            this.Btn_exit.Size = new System.Drawing.Size(48, 42);
            this.Btn_exit.TabIndex = 0;
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_minimize, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_resize, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_exit, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(600, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 48);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // MinecraftMapRendererForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Pnl_Topbar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Minecraftia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MinecraftMapRendererForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Map To Image";
            this.Load += new System.EventHandler(this.MinecraftMapRendererForm_Load);
            this.Pnl_Topbar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Topbar;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button Btn_minimize;
        private System.Windows.Forms.Button Btn_resize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}


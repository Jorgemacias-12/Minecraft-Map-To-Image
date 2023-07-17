namespace Minecraft_Map_Renderer.src.ui.forms
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.Pnl_MainContainer = new System.Windows.Forms.Panel();
            this.Pnl_Topbar = new System.Windows.Forms.Panel();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Pbx_Icon = new System.Windows.Forms.PictureBox();
            this.Tbl_Controls = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.Btn_resize = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Pnl_MainContainer.SuspendLayout();
            this.Pnl_Topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Icon)).BeginInit();
            this.Tbl_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_MainContainer
            // 
            this.Pnl_MainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Pnl_MainContainer.Controls.Add(this.Pnl_Topbar);
            this.Pnl_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_MainContainer.Location = new System.Drawing.Point(0, 0);
            this.Pnl_MainContainer.Name = "Pnl_MainContainer";
            this.Pnl_MainContainer.Size = new System.Drawing.Size(784, 561);
            this.Pnl_MainContainer.TabIndex = 0;
            // 
            // Pnl_Topbar
            // 
            this.Pnl_Topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.Pnl_Topbar.Controls.Add(this.Tbl_Controls);
            this.Pnl_Topbar.Controls.Add(this.Lbl_Title);
            this.Pnl_Topbar.Controls.Add(this.Pbx_Icon);
            this.Pnl_Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Topbar.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Topbar.Name = "Pnl_Topbar";
            this.Pnl_Topbar.Size = new System.Drawing.Size(784, 40);
            this.Pnl_Topbar.TabIndex = 0;
            this.Pnl_Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Topbar_MouseDown);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(48, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(192, 40);
            this.Lbl_Title.TabIndex = 2;
            this.Lbl_Title.Text = "Minecraft Map To Image";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbl_Title_MouseMove);
            // 
            // Pbx_Icon
            // 
            this.Pbx_Icon.BackgroundImage = global::Minecraft_Map_Renderer.Properties.Resources.Map;
            this.Pbx_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pbx_Icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pbx_Icon.Location = new System.Drawing.Point(0, 0);
            this.Pbx_Icon.Name = "Pbx_Icon";
            this.Pbx_Icon.Size = new System.Drawing.Size(48, 40);
            this.Pbx_Icon.TabIndex = 1;
            this.Pbx_Icon.TabStop = false;
            this.Pbx_Icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbl_Title_MouseMove);
            // 
            // Tbl_Controls
            // 
            this.Tbl_Controls.ColumnCount = 3;
            this.Tbl_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Tbl_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Tbl_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Tbl_Controls.Controls.Add(this.Btn_minimize, 0, 0);
            this.Tbl_Controls.Controls.Add(this.Btn_resize, 1, 0);
            this.Tbl_Controls.Controls.Add(this.Btn_exit, 2, 0);
            this.Tbl_Controls.Dock = System.Windows.Forms.DockStyle.Right;
            this.Tbl_Controls.Location = new System.Drawing.Point(584, 0);
            this.Tbl_Controls.Margin = new System.Windows.Forms.Padding(0);
            this.Tbl_Controls.Name = "Tbl_Controls";
            this.Tbl_Controls.RowCount = 1;
            this.Tbl_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tbl_Controls.Size = new System.Drawing.Size(200, 40);
            this.Tbl_Controls.TabIndex = 4;
            // 
            // Btn_minimize
            // 
            this.Btn_minimize.BackgroundImage = global::Minecraft_Map_Renderer.Properties.Resources.minus_solid;
            this.Btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_minimize.FlatAppearance.BorderSize = 0;
            this.Btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimize.Location = new System.Drawing.Point(3, 3);
            this.Btn_minimize.Name = "Btn_minimize";
            this.Btn_minimize.Size = new System.Drawing.Size(60, 34);
            this.Btn_minimize.TabIndex = 2;
            this.Btn_minimize.UseVisualStyleBackColor = true;
            this.Btn_minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // Btn_resize
            // 
            this.Btn_resize.BackgroundImage = global::Minecraft_Map_Renderer.Properties.Resources.window_maximize_solid;
            this.Btn_resize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_resize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_resize.FlatAppearance.BorderSize = 0;
            this.Btn_resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_resize.Location = new System.Drawing.Point(69, 3);
            this.Btn_resize.Name = "Btn_resize";
            this.Btn_resize.Size = new System.Drawing.Size(60, 34);
            this.Btn_resize.TabIndex = 1;
            this.Btn_resize.UseVisualStyleBackColor = true;
            this.Btn_resize.Click += new System.EventHandler(this.Btn_resize_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackgroundImage = global::Minecraft_Map_Renderer.Properties.Resources.xmark_solid;
            this.Btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_exit.FlatAppearance.BorderSize = 0;
            this.Btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.Btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.Location = new System.Drawing.Point(135, 3);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Padding = new System.Windows.Forms.Padding(30);
            this.Btn_exit.Size = new System.Drawing.Size(62, 34);
            this.Btn_exit.TabIndex = 0;
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Pnl_MainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.Move += new System.EventHandler(this.BaseForm_Move);
            this.Pnl_MainContainer.ResumeLayout(false);
            this.Pnl_Topbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Icon)).EndInit();
            this.Tbl_Controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_MainContainer;
        private System.Windows.Forms.Panel Pnl_Topbar;
        private System.Windows.Forms.PictureBox Pbx_Icon;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.TableLayoutPanel Tbl_Controls;
        private System.Windows.Forms.Button Btn_minimize;
        private System.Windows.Forms.Button Btn_resize;
        private System.Windows.Forms.Button Btn_exit;
    }
}
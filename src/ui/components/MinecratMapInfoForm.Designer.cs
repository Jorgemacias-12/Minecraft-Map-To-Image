namespace Minecraft_Map_Renderer.src.ui.components
{
    partial class MinecratMapInfoForm
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
            this.Pnl_TopBar = new System.Windows.Forms.Panel();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Pnl_Information = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.Btn_resize = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_print = new System.Windows.Forms.Button();
            this.Lbl_data = new System.Windows.Forms.Label();
            this.Lbl_dimension = new System.Windows.Forms.Label();
            this.Lbl_Banners = new System.Windows.Forms.Label();
            this.Lbl_Frames = new System.Windows.Forms.Label();
            this.Lbl_locked = new System.Windows.Forms.Label();
            this.Lbl_scale = new System.Windows.Forms.Label();
            this.Lbl_trackingPosition = new System.Windows.Forms.Label();
            this.Lbl_unlimitedTracking = new System.Windows.Forms.Label();
            this.Lbl_XPosition = new System.Windows.Forms.Label();
            this.Lbl_ZPosition = new System.Windows.Forms.Label();
            this.Tbx_frames = new System.Windows.Forms.TextBox();
            this.Tbx_dimension = new System.Windows.Forms.TextBox();
            this.Tbx_banners = new System.Windows.Forms.TextBox();
            this.Tbx_locked = new System.Windows.Forms.TextBox();
            this.Tbx_trackingPosition = new System.Windows.Forms.TextBox();
            this.Tbx_scale = new System.Windows.Forms.TextBox();
            this.Tbx_unlimitedTracking = new System.Windows.Forms.TextBox();
            this.Tbx_XPosition = new System.Windows.Forms.TextBox();
            this.Tbx_ZPosition = new System.Windows.Forms.TextBox();
            this.Pnl_TopBar.SuspendLayout();
            this.Pnl_Information.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_TopBar
            // 
            this.Pnl_TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.Pnl_TopBar.Controls.Add(this.tableLayoutPanel1);
            this.Pnl_TopBar.Controls.Add(this.Lbl_Title);
            this.Pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_TopBar.Location = new System.Drawing.Point(0, 0);
            this.Pnl_TopBar.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_TopBar.Name = "Pnl_TopBar";
            this.Pnl_TopBar.Size = new System.Drawing.Size(982, 50);
            this.Pnl_TopBar.TabIndex = 0;
            this.Pnl_TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_TopBar_MouseDown);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(296, 50);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "   Minecraft Map Information";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbl_Title_MouseDown);
            // 
            // Pnl_Information
            // 
            this.Pnl_Information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Pnl_Information.Controls.Add(this.Tbx_ZPosition);
            this.Pnl_Information.Controls.Add(this.Tbx_XPosition);
            this.Pnl_Information.Controls.Add(this.Tbx_unlimitedTracking);
            this.Pnl_Information.Controls.Add(this.Tbx_scale);
            this.Pnl_Information.Controls.Add(this.Tbx_trackingPosition);
            this.Pnl_Information.Controls.Add(this.Tbx_locked);
            this.Pnl_Information.Controls.Add(this.Tbx_banners);
            this.Pnl_Information.Controls.Add(this.Tbx_dimension);
            this.Pnl_Information.Controls.Add(this.Tbx_frames);
            this.Pnl_Information.Controls.Add(this.Lbl_ZPosition);
            this.Pnl_Information.Controls.Add(this.Lbl_XPosition);
            this.Pnl_Information.Controls.Add(this.Lbl_unlimitedTracking);
            this.Pnl_Information.Controls.Add(this.Lbl_trackingPosition);
            this.Pnl_Information.Controls.Add(this.Lbl_scale);
            this.Pnl_Information.Controls.Add(this.Lbl_locked);
            this.Pnl_Information.Controls.Add(this.Lbl_Frames);
            this.Pnl_Information.Controls.Add(this.Lbl_Banners);
            this.Pnl_Information.Controls.Add(this.Lbl_dimension);
            this.Pnl_Information.Controls.Add(this.Lbl_data);
            this.Pnl_Information.Controls.Add(this.Btn_print);
            this.Pnl_Information.Controls.Add(this.Btn_save);
            this.Pnl_Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Information.Location = new System.Drawing.Point(0, 50);
            this.Pnl_Information.Name = "Pnl_Information";
            this.Pnl_Information.Size = new System.Drawing.Size(982, 653);
            this.Pnl_Information.TabIndex = 1;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(732, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 50);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.Btn_minimize.Size = new System.Drawing.Size(77, 44);
            this.Btn_minimize.TabIndex = 0;
            this.Btn_minimize.UseVisualStyleBackColor = true;
            this.Btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // Btn_resize
            // 
            this.Btn_resize.BackgroundImage = global::Minecraft_Map_Renderer.Properties.Resources.window_maximize_solid;
            this.Btn_resize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_resize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_resize.FlatAppearance.BorderSize = 0;
            this.Btn_resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_resize.Location = new System.Drawing.Point(86, 3);
            this.Btn_resize.Name = "Btn_resize";
            this.Btn_resize.Size = new System.Drawing.Size(77, 44);
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
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.Location = new System.Drawing.Point(169, 3);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(78, 44);
            this.Btn_exit.TabIndex = 2;
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.Btn_save.FlatAppearance.BorderSize = 0;
            this.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_save.Location = new System.Drawing.Point(47, 342);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Padding = new System.Windows.Forms.Padding(2);
            this.Btn_save.Size = new System.Drawing.Size(230, 36);
            this.Btn_save.TabIndex = 0;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = false;
            // 
            // Btn_print
            // 
            this.Btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.Btn_print.FlatAppearance.BorderSize = 0;
            this.Btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_print.Location = new System.Drawing.Point(47, 412);
            this.Btn_print.Name = "Btn_print";
            this.Btn_print.Size = new System.Drawing.Size(230, 36);
            this.Btn_print.TabIndex = 1;
            this.Btn_print.Text = "Print";
            this.Btn_print.UseVisualStyleBackColor = false;
            // 
            // Lbl_data
            // 
            this.Lbl_data.AutoSize = true;
            this.Lbl_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_data.ForeColor = System.Drawing.Color.White;
            this.Lbl_data.Location = new System.Drawing.Point(650, 47);
            this.Lbl_data.Name = "Lbl_data";
            this.Lbl_data.Size = new System.Drawing.Size(76, 36);
            this.Lbl_data.TabIndex = 2;
            this.Lbl_data.Text = "Data";
            this.Lbl_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_dimension
            // 
            this.Lbl_dimension.AutoSize = true;
            this.Lbl_dimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dimension.ForeColor = System.Drawing.Color.White;
            this.Lbl_dimension.Location = new System.Drawing.Point(358, 222);
            this.Lbl_dimension.Name = "Lbl_dimension";
            this.Lbl_dimension.Size = new System.Drawing.Size(110, 25);
            this.Lbl_dimension.TabIndex = 3;
            this.Lbl_dimension.Text = "Dimension:";
            // 
            // Lbl_Banners
            // 
            this.Lbl_Banners.AutoSize = true;
            this.Lbl_Banners.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Banners.ForeColor = System.Drawing.Color.White;
            this.Lbl_Banners.Location = new System.Drawing.Point(358, 144);
            this.Lbl_Banners.Name = "Lbl_Banners";
            this.Lbl_Banners.Size = new System.Drawing.Size(91, 25);
            this.Lbl_Banners.TabIndex = 4;
            this.Lbl_Banners.Text = "Banners:";
            // 
            // Lbl_Frames
            // 
            this.Lbl_Frames.AutoSize = true;
            this.Lbl_Frames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Frames.ForeColor = System.Drawing.Color.White;
            this.Lbl_Frames.Location = new System.Drawing.Point(681, 144);
            this.Lbl_Frames.Name = "Lbl_Frames";
            this.Lbl_Frames.Size = new System.Drawing.Size(84, 25);
            this.Lbl_Frames.TabIndex = 5;
            this.Lbl_Frames.Text = "Frames:";
            // 
            // Lbl_locked
            // 
            this.Lbl_locked.AutoSize = true;
            this.Lbl_locked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_locked.ForeColor = System.Drawing.Color.White;
            this.Lbl_locked.Location = new System.Drawing.Point(358, 293);
            this.Lbl_locked.Name = "Lbl_locked";
            this.Lbl_locked.Size = new System.Drawing.Size(82, 25);
            this.Lbl_locked.TabIndex = 6;
            this.Lbl_locked.Text = "Locked:";
            // 
            // Lbl_scale
            // 
            this.Lbl_scale.AutoSize = true;
            this.Lbl_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_scale.ForeColor = System.Drawing.Color.White;
            this.Lbl_scale.Location = new System.Drawing.Point(681, 293);
            this.Lbl_scale.Name = "Lbl_scale";
            this.Lbl_scale.Size = new System.Drawing.Size(68, 25);
            this.Lbl_scale.TabIndex = 7;
            this.Lbl_scale.Text = "Scale:";
            // 
            // Lbl_trackingPosition
            // 
            this.Lbl_trackingPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_trackingPosition.ForeColor = System.Drawing.Color.White;
            this.Lbl_trackingPosition.Location = new System.Drawing.Point(358, 370);
            this.Lbl_trackingPosition.Name = "Lbl_trackingPosition";
            this.Lbl_trackingPosition.Size = new System.Drawing.Size(110, 62);
            this.Lbl_trackingPosition.TabIndex = 8;
            this.Lbl_trackingPosition.Text = "Tracking Position:";
            // 
            // Lbl_unlimitedTracking
            // 
            this.Lbl_unlimitedTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_unlimitedTracking.ForeColor = System.Drawing.Color.White;
            this.Lbl_unlimitedTracking.Location = new System.Drawing.Point(681, 370);
            this.Lbl_unlimitedTracking.Name = "Lbl_unlimitedTracking";
            this.Lbl_unlimitedTracking.Size = new System.Drawing.Size(104, 62);
            this.Lbl_unlimitedTracking.TabIndex = 9;
            this.Lbl_unlimitedTracking.Text = "Unlimited Tracking:";
            // 
            // Lbl_XPosition
            // 
            this.Lbl_XPosition.AutoSize = true;
            this.Lbl_XPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_XPosition.ForeColor = System.Drawing.Color.White;
            this.Lbl_XPosition.Location = new System.Drawing.Point(358, 470);
            this.Lbl_XPosition.Name = "Lbl_XPosition";
            this.Lbl_XPosition.Size = new System.Drawing.Size(106, 25);
            this.Lbl_XPosition.TabIndex = 10;
            this.Lbl_XPosition.Text = "X Position:";
            // 
            // Lbl_ZPosition
            // 
            this.Lbl_ZPosition.AutoSize = true;
            this.Lbl_ZPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ZPosition.ForeColor = System.Drawing.Color.White;
            this.Lbl_ZPosition.Location = new System.Drawing.Point(681, 470);
            this.Lbl_ZPosition.Name = "Lbl_ZPosition";
            this.Lbl_ZPosition.Size = new System.Drawing.Size(104, 25);
            this.Lbl_ZPosition.TabIndex = 11;
            this.Lbl_ZPosition.Text = "Z Position:";
            // 
            // Tbx_frames
            // 
            this.Tbx_frames.Location = new System.Drawing.Point(790, 148);
            this.Tbx_frames.Name = "Tbx_frames";
            this.Tbx_frames.Size = new System.Drawing.Size(180, 22);
            this.Tbx_frames.TabIndex = 13;
            // 
            // Tbx_dimension
            // 
            this.Tbx_dimension.Location = new System.Drawing.Point(479, 226);
            this.Tbx_dimension.Name = "Tbx_dimension";
            this.Tbx_dimension.Size = new System.Drawing.Size(491, 22);
            this.Tbx_dimension.TabIndex = 14;
            // 
            // Tbx_banners
            // 
            this.Tbx_banners.Location = new System.Drawing.Point(479, 147);
            this.Tbx_banners.Name = "Tbx_banners";
            this.Tbx_banners.Size = new System.Drawing.Size(180, 22);
            this.Tbx_banners.TabIndex = 15;
            // 
            // Tbx_locked
            // 
            this.Tbx_locked.Location = new System.Drawing.Point(479, 297);
            this.Tbx_locked.Name = "Tbx_locked";
            this.Tbx_locked.Size = new System.Drawing.Size(180, 22);
            this.Tbx_locked.TabIndex = 16;
            // 
            // Tbx_trackingPosition
            // 
            this.Tbx_trackingPosition.Location = new System.Drawing.Point(479, 385);
            this.Tbx_trackingPosition.Name = "Tbx_trackingPosition";
            this.Tbx_trackingPosition.Size = new System.Drawing.Size(180, 22);
            this.Tbx_trackingPosition.TabIndex = 17;
            // 
            // Tbx_scale
            // 
            this.Tbx_scale.Location = new System.Drawing.Point(790, 296);
            this.Tbx_scale.Name = "Tbx_scale";
            this.Tbx_scale.Size = new System.Drawing.Size(180, 22);
            this.Tbx_scale.TabIndex = 18;
            // 
            // Tbx_unlimitedTracking
            // 
            this.Tbx_unlimitedTracking.Location = new System.Drawing.Point(790, 385);
            this.Tbx_unlimitedTracking.Name = "Tbx_unlimitedTracking";
            this.Tbx_unlimitedTracking.Size = new System.Drawing.Size(180, 22);
            this.Tbx_unlimitedTracking.TabIndex = 19;
            // 
            // Tbx_XPosition
            // 
            this.Tbx_XPosition.Location = new System.Drawing.Point(479, 474);
            this.Tbx_XPosition.Name = "Tbx_XPosition";
            this.Tbx_XPosition.Size = new System.Drawing.Size(180, 22);
            this.Tbx_XPosition.TabIndex = 20;
            // 
            // Tbx_ZPosition
            // 
            this.Tbx_ZPosition.Location = new System.Drawing.Point(790, 474);
            this.Tbx_ZPosition.Name = "Tbx_ZPosition";
            this.Tbx_ZPosition.Size = new System.Drawing.Size(180, 22);
            this.Tbx_ZPosition.TabIndex = 21;
            // 
            // MinecratMapInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.Pnl_Information);
            this.Controls.Add(this.Pnl_TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MinecratMapInfoForm";
            this.Text = "Minecrat Map Info Form";
            this.Pnl_TopBar.ResumeLayout(false);
            this.Pnl_Information.ResumeLayout(false);
            this.Pnl_Information.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_TopBar;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Panel Pnl_Information;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_minimize;
        private System.Windows.Forms.Button Btn_resize;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button Btn_print;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Label Lbl_data;
        private System.Windows.Forms.Label Lbl_dimension;
        private System.Windows.Forms.Label Lbl_locked;
        private System.Windows.Forms.Label Lbl_Frames;
        private System.Windows.Forms.Label Lbl_Banners;
        private System.Windows.Forms.Label Lbl_XPosition;
        private System.Windows.Forms.Label Lbl_unlimitedTracking;
        private System.Windows.Forms.Label Lbl_trackingPosition;
        private System.Windows.Forms.Label Lbl_scale;
        private System.Windows.Forms.Label Lbl_ZPosition;
        private System.Windows.Forms.TextBox Tbx_dimension;
        private System.Windows.Forms.TextBox Tbx_frames;
        private System.Windows.Forms.TextBox Tbx_ZPosition;
        private System.Windows.Forms.TextBox Tbx_XPosition;
        private System.Windows.Forms.TextBox Tbx_unlimitedTracking;
        private System.Windows.Forms.TextBox Tbx_scale;
        private System.Windows.Forms.TextBox Tbx_trackingPosition;
        private System.Windows.Forms.TextBox Tbx_locked;
        private System.Windows.Forms.TextBox Tbx_banners;
    }
}
namespace Minecraft_Map_Renderer.src.ui.components
{
    partial class MinecraftMapForm
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
            this.Tlp_WindowControils = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Pnl_MapView = new Minecraft_Map_Renderer.src.ui.components.CustomPanel();
            this.Pbx_MapImage = new System.Windows.Forms.PictureBox();
            this.Pnl_ExportControls = new Minecraft_Map_Renderer.src.ui.components.CustomPanel();
            this.Cmb_ImageExtensions = new System.Windows.Forms.ComboBox();
            this.Lbl_ImageExtensions = new System.Windows.Forms.Label();
            this.Btn_Export = new System.Windows.Forms.Button();
            this.Pnl_InfoContainer = new Minecraft_Map_Renderer.src.ui.components.CustomPanel();
            this.Tlp_MapInfo = new System.Windows.Forms.TableLayoutPanel();
            this.Pnl_Dimension = new Minecraft_Map_Renderer.src.ui.components.CustomPanel();
            this.Lbl_Dimension = new System.Windows.Forms.Label();
            this.Pnl_Locked = new Minecraft_Map_Renderer.src.ui.components.CustomPanel();
            this.Lbl_Locked = new System.Windows.Forms.Label();
            this.Pnl_Scale = new Minecraft_Map_Renderer.src.ui.components.CustomPanel();
            this.Lbl_Scale = new System.Windows.Forms.Label();
            this.Pnl_TrackingPosition = new Minecraft_Map_Renderer.src.ui.components.CustomPanel();
            this.Lbl_TrackingPosition = new System.Windows.Forms.Label();
            this.Pnl_UnlimitedTracking = new Minecraft_Map_Renderer.src.ui.components.CustomPanel();
            this.Lbl_UnlimitedTracking = new System.Windows.Forms.Label();
            this.Pnl_XCenter = new Minecraft_Map_Renderer.src.ui.components.CustomPanel();
            this.Lbl_XCenter = new System.Windows.Forms.Label();
            this.Pnl_ZCenter = new Minecraft_Map_Renderer.src.ui.components.CustomPanel();
            this.Lbl_ZCenter = new System.Windows.Forms.Label();
            this.Pnl_Width = new Minecraft_Map_Renderer.src.ui.components.CustomPanel();
            this.Lbl_Width = new System.Windows.Forms.Label();
            this.Pnl_Height = new Minecraft_Map_Renderer.src.ui.components.CustomPanel();
            this.Lbl_Height = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Pnl_TopBar.SuspendLayout();
            this.Tlp_WindowControils.SuspendLayout();
            this.Pnl_MapView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_MapImage)).BeginInit();
            this.Pnl_ExportControls.SuspendLayout();
            this.Pnl_InfoContainer.SuspendLayout();
            this.Tlp_MapInfo.SuspendLayout();
            this.Pnl_Dimension.SuspendLayout();
            this.Pnl_Locked.SuspendLayout();
            this.Pnl_Scale.SuspendLayout();
            this.Pnl_TrackingPosition.SuspendLayout();
            this.Pnl_UnlimitedTracking.SuspendLayout();
            this.Pnl_XCenter.SuspendLayout();
            this.Pnl_ZCenter.SuspendLayout();
            this.Pnl_Width.SuspendLayout();
            this.Pnl_Height.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_TopBar
            // 
            this.Pnl_TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.Pnl_TopBar.Controls.Add(this.Tlp_WindowControils);
            this.Pnl_TopBar.Controls.Add(this.Lbl_Title);
            this.Pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_TopBar.Location = new System.Drawing.Point(0, 0);
            this.Pnl_TopBar.Name = "Pnl_TopBar";
            this.Pnl_TopBar.Size = new System.Drawing.Size(800, 41);
            this.Pnl_TopBar.TabIndex = 1;
            this.Pnl_TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_TopBar_MouseDown);
            // 
            // Tlp_WindowControils
            // 
            this.Tlp_WindowControils.ColumnCount = 2;
            this.Tlp_WindowControils.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_WindowControils.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_WindowControils.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_WindowControils.Controls.Add(this.Btn_minimize, 0, 0);
            this.Tlp_WindowControils.Controls.Add(this.Btn_exit, 1, 0);
            this.Tlp_WindowControils.Dock = System.Windows.Forms.DockStyle.Right;
            this.Tlp_WindowControils.Location = new System.Drawing.Point(620, 0);
            this.Tlp_WindowControils.Margin = new System.Windows.Forms.Padding(0);
            this.Tlp_WindowControils.Name = "Tlp_WindowControils";
            this.Tlp_WindowControils.RowCount = 1;
            this.Tlp_WindowControils.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_WindowControils.Size = new System.Drawing.Size(180, 41);
            this.Tlp_WindowControils.TabIndex = 1;
            // 
            // Btn_minimize
            // 
            this.Btn_minimize.BackgroundImage = global::Minecraft_Map_Renderer.Properties.Resources.minus_solid;
            this.Btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_minimize.FlatAppearance.BorderSize = 0;
            this.Btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimize.Location = new System.Drawing.Point(2, 2);
            this.Btn_minimize.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_minimize.Name = "Btn_minimize";
            this.Btn_minimize.Size = new System.Drawing.Size(86, 37);
            this.Btn_minimize.TabIndex = 0;
            this.Btn_minimize.UseVisualStyleBackColor = true;
            this.Btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackgroundImage = global::Minecraft_Map_Renderer.Properties.Resources.xmark_solid;
            this.Btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_exit.FlatAppearance.BorderSize = 0;
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.Location = new System.Drawing.Point(92, 2);
            this.Btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(86, 37);
            this.Btn_exit.TabIndex = 2;
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Lbl_Title.Size = new System.Drawing.Size(214, 41);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Minecraft Map Information";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbl_Title_MouseDown);
            // 
            // Pnl_MapView
            // 
            this.Pnl_MapView.Controls.Add(this.Pbx_MapImage);
            this.Pnl_MapView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_MapView.Location = new System.Drawing.Point(0, 41);
            this.Pnl_MapView.Name = "Pnl_MapView";
            this.Pnl_MapView.Padding = new System.Windows.Forms.Padding(10);
            this.Pnl_MapView.Size = new System.Drawing.Size(410, 427);
            this.Pnl_MapView.TabIndex = 4;
            // 
            // Pbx_MapImage
            // 
            this.Pbx_MapImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pbx_MapImage.Location = new System.Drawing.Point(10, 10);
            this.Pbx_MapImage.Name = "Pbx_MapImage";
            this.Pbx_MapImage.Size = new System.Drawing.Size(390, 407);
            this.Pbx_MapImage.TabIndex = 0;
            this.Pbx_MapImage.TabStop = false;
            // 
            // Pnl_ExportControls
            // 
            this.Pnl_ExportControls.Controls.Add(this.Cmb_ImageExtensions);
            this.Pnl_ExportControls.Controls.Add(this.Lbl_ImageExtensions);
            this.Pnl_ExportControls.Controls.Add(this.Btn_Export);
            this.Pnl_ExportControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_ExportControls.Location = new System.Drawing.Point(0, 468);
            this.Pnl_ExportControls.Name = "Pnl_ExportControls";
            this.Pnl_ExportControls.Size = new System.Drawing.Size(410, 132);
            this.Pnl_ExportControls.TabIndex = 3;
            // 
            // Cmb_ImageExtensions
            // 
            this.Cmb_ImageExtensions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Cmb_ImageExtensions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_ImageExtensions.ForeColor = System.Drawing.Color.White;
            this.Cmb_ImageExtensions.FormattingEnabled = true;
            this.Cmb_ImageExtensions.IntegralHeight = false;
            this.Cmb_ImageExtensions.ItemHeight = 13;
            this.Cmb_ImageExtensions.Location = new System.Drawing.Point(87, 23);
            this.Cmb_ImageExtensions.Name = "Cmb_ImageExtensions";
            this.Cmb_ImageExtensions.Size = new System.Drawing.Size(313, 21);
            this.Cmb_ImageExtensions.TabIndex = 2;
            // 
            // Lbl_ImageExtensions
            // 
            this.Lbl_ImageExtensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ImageExtensions.Location = new System.Drawing.Point(12, 23);
            this.Lbl_ImageExtensions.Name = "Lbl_ImageExtensions";
            this.Lbl_ImageExtensions.Size = new System.Drawing.Size(69, 21);
            this.Lbl_ImageExtensions.TabIndex = 1;
            this.Lbl_ImageExtensions.Text = "Format:";
            this.Lbl_ImageExtensions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Export
            // 
            this.Btn_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.Btn_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Export.FlatAppearance.BorderSize = 0;
            this.Btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Export.ForeColor = System.Drawing.Color.White;
            this.Btn_Export.Location = new System.Drawing.Point(12, 84);
            this.Btn_Export.Name = "Btn_Export";
            this.Btn_Export.Size = new System.Drawing.Size(388, 36);
            this.Btn_Export.TabIndex = 0;
            this.Btn_Export.Text = "Save as ";
            this.Btn_Export.UseVisualStyleBackColor = false;
            this.Btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // Pnl_InfoContainer
            // 
            this.Pnl_InfoContainer.Controls.Add(this.Tlp_MapInfo);
            this.Pnl_InfoContainer.Controls.Add(this.Lbl_Name);
            this.Pnl_InfoContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_InfoContainer.Location = new System.Drawing.Point(410, 41);
            this.Pnl_InfoContainer.Name = "Pnl_InfoContainer";
            this.Pnl_InfoContainer.Size = new System.Drawing.Size(390, 559);
            this.Pnl_InfoContainer.TabIndex = 2;
            // 
            // Tlp_MapInfo
            // 
            this.Tlp_MapInfo.BackColor = System.Drawing.Color.Transparent;
            this.Tlp_MapInfo.ColumnCount = 2;
            this.Tlp_MapInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_MapInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_MapInfo.Controls.Add(this.Pnl_Dimension, 0, 0);
            this.Tlp_MapInfo.Controls.Add(this.Pnl_Locked, 1, 0);
            this.Tlp_MapInfo.Controls.Add(this.Pnl_Scale, 0, 1);
            this.Tlp_MapInfo.Controls.Add(this.Pnl_TrackingPosition, 1, 1);
            this.Tlp_MapInfo.Controls.Add(this.Pnl_UnlimitedTracking, 0, 2);
            this.Tlp_MapInfo.Controls.Add(this.Pnl_XCenter, 1, 2);
            this.Tlp_MapInfo.Controls.Add(this.Pnl_ZCenter, 0, 3);
            this.Tlp_MapInfo.Controls.Add(this.Pnl_Width, 1, 3);
            this.Tlp_MapInfo.Controls.Add(this.Pnl_Height, 0, 4);
            this.Tlp_MapInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_MapInfo.Location = new System.Drawing.Point(0, 41);
            this.Tlp_MapInfo.Name = "Tlp_MapInfo";
            this.Tlp_MapInfo.Padding = new System.Windows.Forms.Padding(10);
            this.Tlp_MapInfo.RowCount = 5;
            this.Tlp_MapInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tlp_MapInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tlp_MapInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tlp_MapInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tlp_MapInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tlp_MapInfo.Size = new System.Drawing.Size(390, 518);
            this.Tlp_MapInfo.TabIndex = 1;
            // 
            // Pnl_Dimension
            // 
            this.Pnl_Dimension.Controls.Add(this.Lbl_Dimension);
            this.Pnl_Dimension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Dimension.Location = new System.Drawing.Point(13, 13);
            this.Pnl_Dimension.Name = "Pnl_Dimension";
            this.Pnl_Dimension.Size = new System.Drawing.Size(179, 93);
            this.Pnl_Dimension.TabIndex = 0;
            // 
            // Lbl_Dimension
            // 
            this.Lbl_Dimension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Dimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dimension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.Lbl_Dimension.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Dimension.Name = "Lbl_Dimension";
            this.Lbl_Dimension.Size = new System.Drawing.Size(179, 93);
            this.Lbl_Dimension.TabIndex = 0;
            this.Lbl_Dimension.Text = "Dimension:";
            this.Lbl_Dimension.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Locked
            // 
            this.Pnl_Locked.Controls.Add(this.Lbl_Locked);
            this.Pnl_Locked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Locked.Location = new System.Drawing.Point(198, 13);
            this.Pnl_Locked.Name = "Pnl_Locked";
            this.Pnl_Locked.Size = new System.Drawing.Size(179, 93);
            this.Pnl_Locked.TabIndex = 1;
            // 
            // Lbl_Locked
            // 
            this.Lbl_Locked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Locked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Locked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.Lbl_Locked.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Locked.Name = "Lbl_Locked";
            this.Lbl_Locked.Size = new System.Drawing.Size(179, 93);
            this.Lbl_Locked.TabIndex = 1;
            this.Lbl_Locked.Text = "Locked:";
            this.Lbl_Locked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Scale
            // 
            this.Pnl_Scale.Controls.Add(this.Lbl_Scale);
            this.Pnl_Scale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Scale.Location = new System.Drawing.Point(13, 112);
            this.Pnl_Scale.Name = "Pnl_Scale";
            this.Pnl_Scale.Size = new System.Drawing.Size(179, 93);
            this.Pnl_Scale.TabIndex = 2;
            // 
            // Lbl_Scale
            // 
            this.Lbl_Scale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.Lbl_Scale.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Scale.Name = "Lbl_Scale";
            this.Lbl_Scale.Size = new System.Drawing.Size(179, 93);
            this.Lbl_Scale.TabIndex = 1;
            this.Lbl_Scale.Text = "Scale:";
            this.Lbl_Scale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_TrackingPosition
            // 
            this.Pnl_TrackingPosition.Controls.Add(this.Lbl_TrackingPosition);
            this.Pnl_TrackingPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_TrackingPosition.Location = new System.Drawing.Point(198, 112);
            this.Pnl_TrackingPosition.Name = "Pnl_TrackingPosition";
            this.Pnl_TrackingPosition.Size = new System.Drawing.Size(179, 93);
            this.Pnl_TrackingPosition.TabIndex = 3;
            // 
            // Lbl_TrackingPosition
            // 
            this.Lbl_TrackingPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_TrackingPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TrackingPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.Lbl_TrackingPosition.Location = new System.Drawing.Point(0, 0);
            this.Lbl_TrackingPosition.Name = "Lbl_TrackingPosition";
            this.Lbl_TrackingPosition.Size = new System.Drawing.Size(179, 93);
            this.Lbl_TrackingPosition.TabIndex = 0;
            this.Lbl_TrackingPosition.Text = "Tracking Position:";
            this.Lbl_TrackingPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_UnlimitedTracking
            // 
            this.Pnl_UnlimitedTracking.Controls.Add(this.Lbl_UnlimitedTracking);
            this.Pnl_UnlimitedTracking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_UnlimitedTracking.Location = new System.Drawing.Point(13, 211);
            this.Pnl_UnlimitedTracking.Name = "Pnl_UnlimitedTracking";
            this.Pnl_UnlimitedTracking.Size = new System.Drawing.Size(179, 93);
            this.Pnl_UnlimitedTracking.TabIndex = 4;
            // 
            // Lbl_UnlimitedTracking
            // 
            this.Lbl_UnlimitedTracking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_UnlimitedTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UnlimitedTracking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.Lbl_UnlimitedTracking.Location = new System.Drawing.Point(0, 0);
            this.Lbl_UnlimitedTracking.Name = "Lbl_UnlimitedTracking";
            this.Lbl_UnlimitedTracking.Size = new System.Drawing.Size(179, 93);
            this.Lbl_UnlimitedTracking.TabIndex = 0;
            this.Lbl_UnlimitedTracking.Text = "Unlimited Tracking: ";
            this.Lbl_UnlimitedTracking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_XCenter
            // 
            this.Pnl_XCenter.Controls.Add(this.Lbl_XCenter);
            this.Pnl_XCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_XCenter.Location = new System.Drawing.Point(198, 211);
            this.Pnl_XCenter.Name = "Pnl_XCenter";
            this.Pnl_XCenter.Size = new System.Drawing.Size(179, 93);
            this.Pnl_XCenter.TabIndex = 5;
            // 
            // Lbl_XCenter
            // 
            this.Lbl_XCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_XCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_XCenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.Lbl_XCenter.Location = new System.Drawing.Point(0, 0);
            this.Lbl_XCenter.Name = "Lbl_XCenter";
            this.Lbl_XCenter.Size = new System.Drawing.Size(179, 93);
            this.Lbl_XCenter.TabIndex = 0;
            this.Lbl_XCenter.Text = "X Center: ";
            this.Lbl_XCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_ZCenter
            // 
            this.Pnl_ZCenter.Controls.Add(this.Lbl_ZCenter);
            this.Pnl_ZCenter.Location = new System.Drawing.Point(13, 310);
            this.Pnl_ZCenter.Name = "Pnl_ZCenter";
            this.Pnl_ZCenter.Size = new System.Drawing.Size(179, 93);
            this.Pnl_ZCenter.TabIndex = 6;
            // 
            // Lbl_ZCenter
            // 
            this.Lbl_ZCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_ZCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ZCenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.Lbl_ZCenter.Location = new System.Drawing.Point(0, 0);
            this.Lbl_ZCenter.Name = "Lbl_ZCenter";
            this.Lbl_ZCenter.Size = new System.Drawing.Size(179, 93);
            this.Lbl_ZCenter.TabIndex = 0;
            this.Lbl_ZCenter.Text = "Z Center: ";
            this.Lbl_ZCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Width
            // 
            this.Pnl_Width.Controls.Add(this.Lbl_Width);
            this.Pnl_Width.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Width.Location = new System.Drawing.Point(198, 310);
            this.Pnl_Width.Name = "Pnl_Width";
            this.Pnl_Width.Size = new System.Drawing.Size(179, 93);
            this.Pnl_Width.TabIndex = 7;
            // 
            // Lbl_Width
            // 
            this.Lbl_Width.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Width.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.Lbl_Width.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Width.Name = "Lbl_Width";
            this.Lbl_Width.Size = new System.Drawing.Size(179, 93);
            this.Lbl_Width.TabIndex = 0;
            this.Lbl_Width.Text = "Width: ";
            this.Lbl_Width.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Height
            // 
            this.Pnl_Height.Controls.Add(this.Lbl_Height);
            this.Pnl_Height.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Height.Location = new System.Drawing.Point(13, 409);
            this.Pnl_Height.Name = "Pnl_Height";
            this.Pnl_Height.Size = new System.Drawing.Size(179, 96);
            this.Pnl_Height.TabIndex = 8;
            // 
            // Lbl_Height
            // 
            this.Lbl_Height.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Height.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.Lbl_Height.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Height.Name = "Lbl_Height";
            this.Lbl_Height.Size = new System.Drawing.Size(179, 96);
            this.Lbl_Height.TabIndex = 0;
            this.Lbl_Height.Text = "Height: ";
            this.Lbl_Height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(390, 41);
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "Map name here";
            this.Lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinecraftMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.Pnl_MapView);
            this.Controls.Add(this.Pnl_ExportControls);
            this.Controls.Add(this.Pnl_InfoContainer);
            this.Controls.Add(this.Pnl_TopBar);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MinecraftMapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MinecraftMapForm";
            this.Load += new System.EventHandler(this.MinecraftMapForm_Load);
            this.Pnl_TopBar.ResumeLayout(false);
            this.Tlp_WindowControils.ResumeLayout(false);
            this.Pnl_MapView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_MapImage)).EndInit();
            this.Pnl_ExportControls.ResumeLayout(false);
            this.Pnl_InfoContainer.ResumeLayout(false);
            this.Tlp_MapInfo.ResumeLayout(false);
            this.Pnl_Dimension.ResumeLayout(false);
            this.Pnl_Locked.ResumeLayout(false);
            this.Pnl_Scale.ResumeLayout(false);
            this.Pnl_TrackingPosition.ResumeLayout(false);
            this.Pnl_UnlimitedTracking.ResumeLayout(false);
            this.Pnl_XCenter.ResumeLayout(false);
            this.Pnl_ZCenter.ResumeLayout(false);
            this.Pnl_Width.ResumeLayout(false);
            this.Pnl_Height.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_TopBar;
        private System.Windows.Forms.TableLayoutPanel Tlp_WindowControils;
        private System.Windows.Forms.Button Btn_minimize;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Label Lbl_Title;
        private CustomPanel Pnl_InfoContainer;
        private CustomPanel Pnl_ExportControls;
        private CustomPanel Pnl_MapView;
        private System.Windows.Forms.PictureBox Pbx_MapImage;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TableLayoutPanel Tlp_MapInfo;
        private CustomPanel Pnl_Dimension;
        private System.Windows.Forms.Label Lbl_Dimension;
        private CustomPanel Pnl_Locked;
        private System.Windows.Forms.Label Lbl_Locked;
        private CustomPanel Pnl_Scale;
        private System.Windows.Forms.Label Lbl_Scale;
        private CustomPanel Pnl_TrackingPosition;
        private CustomPanel Pnl_UnlimitedTracking;
        private CustomPanel Pnl_XCenter;
        private CustomPanel Pnl_ZCenter;
        private CustomPanel Pnl_Width;
        private CustomPanel Pnl_Height;
        private System.Windows.Forms.Label Lbl_TrackingPosition;
        private System.Windows.Forms.Label Lbl_UnlimitedTracking;
        private System.Windows.Forms.Label Lbl_XCenter;
        private System.Windows.Forms.Label Lbl_ZCenter;
        private System.Windows.Forms.Label Lbl_Width;
        private System.Windows.Forms.Label Lbl_Height;
        private System.Windows.Forms.Button Btn_Export;
        private System.Windows.Forms.Label Lbl_ImageExtensions;
        private System.Windows.Forms.ComboBox Cmb_ImageExtensions;
    }
}
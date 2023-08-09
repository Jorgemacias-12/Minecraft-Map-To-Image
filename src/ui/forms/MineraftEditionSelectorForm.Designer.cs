namespace Minecraft_Map_Renderer.src.ui.forms
{
    partial class MinecraftEditionSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinecraftEditionSelectorForm));
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Pnl_Container = new System.Windows.Forms.Panel();
            this.Tlp_Editions = new System.Windows.Forms.TableLayoutPanel();
            this.Mev_Bedrock = new Minecraft_Map_Renderer.src.ui.forms.MinecraftEditionView();
            this.Mev_Java = new Minecraft_Map_Renderer.src.ui.forms.MinecraftEditionView();
            this.Pnl_Container.SuspendLayout();
            this.Tlp_Editions.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(766, 50);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Minecraft Map Item Exporter";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Container
            // 
            this.Pnl_Container.Controls.Add(this.Tlp_Editions);
            this.Pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Container.Location = new System.Drawing.Point(0, 50);
            this.Pnl_Container.Name = "Pnl_Container";
            this.Pnl_Container.Padding = new System.Windows.Forms.Padding(10);
            this.Pnl_Container.Size = new System.Drawing.Size(766, 450);
            this.Pnl_Container.TabIndex = 1;
            // 
            // Tlp_Editions
            // 
            this.Tlp_Editions.ColumnCount = 2;
            this.Tlp_Editions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_Editions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_Editions.Controls.Add(this.Mev_Bedrock, 0, 0);
            this.Tlp_Editions.Controls.Add(this.Mev_Java, 1, 0);
            this.Tlp_Editions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Editions.Location = new System.Drawing.Point(10, 10);
            this.Tlp_Editions.Name = "Tlp_Editions";
            this.Tlp_Editions.Padding = new System.Windows.Forms.Padding(10);
            this.Tlp_Editions.RowCount = 1;
            this.Tlp_Editions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_Editions.Size = new System.Drawing.Size(746, 430);
            this.Tlp_Editions.TabIndex = 0;
            // 
            // Mev_Bedrock
            // 
            this.Mev_Bedrock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mev_Bedrock.EditionName = null;
            this.Mev_Bedrock.Image = null;
            this.Mev_Bedrock.Location = new System.Drawing.Point(3, 3);
            this.Mev_Bedrock.Name = "Mev_Bedrock";
            this.Mev_Bedrock.Size = new System.Drawing.Size(367, 419);
            this.Mev_Bedrock.TabIndex = 0;
            // 
            // Mev_Java
            // 
            this.Mev_Java.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mev_Java.EditionName = null;
            this.Mev_Java.Image = null;
            this.Mev_Java.Location = new System.Drawing.Point(376, 3);
            this.Mev_Java.Name = "Mev_Java";
            this.Mev_Java.Size = new System.Drawing.Size(367, 419);
            this.Mev_Java.TabIndex = 1;
            // 
            // MinecraftEditionSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(766, 500);
            this.ControlBox = false;
            this.Controls.Add(this.Pnl_Container);
            this.Controls.Add(this.Lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MinecraftEditionSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MineraftEditionSelectorForm";
            this.Load += new System.EventHandler(this.MinecraftEditionSelectorForm_Load);
            this.Pnl_Container.ResumeLayout(false);
            this.Tlp_Editions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Panel Pnl_Container;
        private System.Windows.Forms.TableLayoutPanel Tlp_Editions;
        private MinecraftEditionView Mev_Bedrock;
        private MinecraftEditionView Mev_Java;
    }
}
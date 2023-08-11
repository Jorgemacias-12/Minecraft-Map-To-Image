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
            this.Pnl_Exit = new System.Windows.Forms.Panel();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Mev_Bedrock = new Minecraft_Map_Renderer.src.ui.forms.MinecraftEditionView();
            this.Mev_Java = new Minecraft_Map_Renderer.src.ui.forms.MinecraftEditionView();
            this.Pnl_Container.SuspendLayout();
            this.Tlp_Editions.SuspendLayout();
            this.Pnl_Exit.SuspendLayout();
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
            this.Pnl_Container.Size = new System.Drawing.Size(766, 449);
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
            this.Tlp_Editions.Size = new System.Drawing.Size(746, 429);
            this.Tlp_Editions.TabIndex = 0;
            // 
            // Pnl_Exit
            // 
            this.Pnl_Exit.Controls.Add(this.Btn_Exit);
            this.Pnl_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Exit.Location = new System.Drawing.Point(0, 499);
            this.Pnl_Exit.Name = "Pnl_Exit";
            this.Pnl_Exit.Padding = new System.Windows.Forms.Padding(10);
            this.Pnl_Exit.Size = new System.Drawing.Size(766, 51);
            this.Pnl_Exit.TabIndex = 1;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(211)))), ((int)(((byte)(176)))));
            this.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.White;
            this.Btn_Exit.Location = new System.Drawing.Point(10, 10);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(746, 31);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.Text = "Salir";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Mev_Bedrock
            // 
            this.Mev_Bedrock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mev_Bedrock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mev_Bedrock.Edition = Minecraft_Map_Renderer.src.logic.MinecraftEdition.Java;
            this.Mev_Bedrock.EditionName = null;
            this.Mev_Bedrock.Image = null;
            this.Mev_Bedrock.Location = new System.Drawing.Point(13, 13);
            this.Mev_Bedrock.Name = "Mev_Bedrock";
            this.Mev_Bedrock.Size = new System.Drawing.Size(357, 403);
            this.Mev_Bedrock.TabIndex = 0;
            // 
            // Mev_Java
            // 
            this.Mev_Java.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mev_Java.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mev_Java.Edition = Minecraft_Map_Renderer.src.logic.MinecraftEdition.Java;
            this.Mev_Java.EditionName = null;
            this.Mev_Java.Image = null;
            this.Mev_Java.Location = new System.Drawing.Point(376, 13);
            this.Mev_Java.Name = "Mev_Java";
            this.Mev_Java.Size = new System.Drawing.Size(357, 403);
            this.Mev_Java.TabIndex = 1;
            // 
            // MinecraftEditionSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(766, 550);
            this.ControlBox = false;
            this.Controls.Add(this.Pnl_Container);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Pnl_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MinecraftEditionSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MineraftEditionSelectorForm";
            this.Load += new System.EventHandler(this.MinecraftEditionSelectorForm_Load);
            this.Pnl_Container.ResumeLayout(false);
            this.Tlp_Editions.ResumeLayout(false);
            this.Pnl_Exit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Panel Pnl_Container;
        private System.Windows.Forms.TableLayoutPanel Tlp_Editions;
        private MinecraftEditionView Mev_Bedrock;
        private MinecraftEditionView Mev_Java;
        private System.Windows.Forms.Panel Pnl_Exit;
        private System.Windows.Forms.Button Btn_Exit;
    }
}
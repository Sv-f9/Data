namespace Data
{
    partial class Data
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataProgramControl1 = new DataProgramControl();
            this.showDataControl1 = new ShowDataControl();
            this.settingControl1 = new SettingControl();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.collectData1 = new CollectData();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(985, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "by Sv Nv";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dataProgramControl1);
            this.panel1.Controls.Add(this.showDataControl1);
            this.panel1.Controls.Add(this.settingControl1);
            this.panel1.Controls.Add(this.metroTile2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.metroTile3);
            this.panel1.Controls.Add(this.metroTile5);
            this.panel1.Controls.Add(this.metroTile6);
            this.panel1.Controls.Add(this.collectData1);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 597);
            this.panel1.TabIndex = 10;
            // 
            // dataProgramControl1
            // 
            this.dataProgramControl1.Location = new System.Drawing.Point(0, -22);
            this.dataProgramControl1.Name = "dataProgramControl1";
            this.dataProgramControl1.Size = new System.Drawing.Size(1052, 616);
            this.dataProgramControl1.TabIndex = 47;
            this.dataProgramControl1.Load += new System.EventHandler(this.dataProgramControl1_Load);
            // 
            // showDataControl1
            // 
            this.showDataControl1.Location = new System.Drawing.Point(0, -19);
            this.showDataControl1.Name = "showDataControl1";
            this.showDataControl1.Size = new System.Drawing.Size(1052, 616);
            this.showDataControl1.TabIndex = 46;
            // 
            // settingControl1
            // 
            this.settingControl1.Location = new System.Drawing.Point(0, 0);
            this.settingControl1.Name = "settingControl1";
            this.settingControl1.Size = new System.Drawing.Size(1052, 616);
            this.settingControl1.TabIndex = 45;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.Location = new System.Drawing.Point(217, 221);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(198, 111);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 39;
            this.metroTile2.Text = "Вывод данных";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileImage = global::Data.Properties.Resources.png_transparent_database_computer_icons_computer_servers_data_icon_text_data_share_icon1;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click_2);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile3.Location = new System.Drawing.Point(421, 221);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(198, 111);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile3.TabIndex = 40;
            this.metroTile3.Text = "Сбор информации";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.TileImage = global::Data.Properties.Resources._51157;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click_1);
            // 
            // metroTile5
            // 
            this.metroTile5.AccessibleName = "";
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTile5.BackColor = System.Drawing.Color.Green;
            this.metroTile5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.metroTile5.Location = new System.Drawing.Point(3, 507);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(114, 90);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile5.TabIndex = 5;
            this.metroTile5.Text = "Настройки";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile5.TileImage = global::Data.Properties.Resources._6603_img_3135341;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile5.UseCustomForeColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile6.Location = new System.Drawing.Point(625, 221);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(198, 111);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile6.TabIndex = 42;
            this.metroTile6.Text = "Справка";
            this.metroTile6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile6.TileImage = global::Data.Properties.Resources.img_219511;
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseTileImage = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // collectData1
            // 
            this.collectData1.Location = new System.Drawing.Point(0, -19);
            this.collectData1.Name = "collectData1";
            this.collectData1.Size = new System.Drawing.Size(1052, 616);
            this.collectData1.TabIndex = 9;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 622);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Data";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.TransparencyKey = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTile5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public CollectData collectData1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile6;
        private SettingControl settingControl1;
        private ShowDataControl showDataControl1;
        private DataProgramControl dataProgramControl1;
    }
}


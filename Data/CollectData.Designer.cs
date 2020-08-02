namespace Data
{
    partial class CollectData
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectiveCollectControl1 = new SelectiveCollectControl();
            this.allCollectControl1 = new AllCollectControl();
            this.quickCollectControl1 = new QuickCollectControl();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectiveCollectControl1);
            this.panel1.Controls.Add(this.allCollectControl1);
            this.panel1.Controls.Add(this.quickCollectControl1);
            this.panel1.Location = new System.Drawing.Point(182, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 534);
            this.panel1.TabIndex = 1;
            // 
            // selectiveCollectControl1
            // 
            this.selectiveCollectControl1.BackColor = System.Drawing.SystemColors.Control;
            this.selectiveCollectControl1.Location = new System.Drawing.Point(0, 0);
            this.selectiveCollectControl1.Name = "selectiveCollectControl1";
            this.selectiveCollectControl1.Size = new System.Drawing.Size(876, 534);
            this.selectiveCollectControl1.TabIndex = 2;
            // 
            // allCollectControl1
            // 
            this.allCollectControl1.BackColor = System.Drawing.SystemColors.Control;
            this.allCollectControl1.Location = new System.Drawing.Point(0, -3);
            this.allCollectControl1.Name = "allCollectControl1";
            this.allCollectControl1.Size = new System.Drawing.Size(876, 534);
            this.allCollectControl1.TabIndex = 1;
            // 
            // quickCollectControl1
            // 
            this.quickCollectControl1.BackColor = System.Drawing.SystemColors.Control;
            this.quickCollectControl1.Location = new System.Drawing.Point(0, 0);
            this.quickCollectControl1.Name = "quickCollectControl1";
            this.quickCollectControl1.Size = new System.Drawing.Size(876, 534);
            this.quickCollectControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сбор информации";
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.SystemColors.Control;
            this.metroTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroTile3.Location = new System.Drawing.Point(9, 133);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(167, 42);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "Быстрый сбор";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.SystemColors.Control;
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroTile2.Location = new System.Drawing.Point(9, 85);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(167, 42);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Полный сбор";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.BackColor = System.Drawing.SystemColors.Control;
            this.metroTile4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroTile4.Location = new System.Drawing.Point(9, 180);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(167, 42);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile4.TabIndex = 5;
            this.metroTile4.Text = "Выборочный ";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile4.UseCustomForeColor = true;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Green;
            this.SidePanel.Location = new System.Drawing.Point(3, 86);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 41);
            this.SidePanel.TabIndex = 0;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.SystemColors.Control;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(173, 77);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Назад";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileImage = global::Data.Properties.Resources.back_icon1;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(182, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 59);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.metroTile1);
            this.panel3.Controls.Add(this.metroTile3);
            this.panel3.Controls.Add(this.SidePanel);
            this.panel3.Controls.Add(this.metroTile2);
            this.panel3.Controls.Add(this.metroTile4);
            this.panel3.Location = new System.Drawing.Point(0, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 595);
            this.panel3.TabIndex = 3;
            // 
            // CollectData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CollectData";
            this.Size = new System.Drawing.Size(1052, 616);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.Panel SidePanel;
        private QuickCollectControl quickCollectControl1;
        private AllCollectControl allCollectControl1;
        private SelectiveCollectControl selectiveCollectControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

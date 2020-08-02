namespace Data
{
    partial class ShowDataControl
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.label5 = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textBox1.Location = new System.Drawing.Point(281, 540);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 28);
            this.textBox1.TabIndex = 7;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroTile4.Location = new System.Drawing.Point(421, 574);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(190, 39);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile4.TabIndex = 10;
            this.metroTile4.Text = "Вывести информацию";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile4.UseCustomForeColor = true;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseStyleColors = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(188, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(785, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Введите ник аккаунта или выберите через listBox, чью информацию вы хотите узнать";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(245, 253);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(506, 257);
            this.pieChart1.TabIndex = 16;
            this.pieChart1.Text = "pieChart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(491, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.metroTile7);
            this.panel3.Controls.Add(this.metroTile3);
            this.panel3.Controls.Add(this.metroTile5);
            this.panel3.Controls.Add(this.metroTile6);
            this.panel3.Location = new System.Drawing.Point(3, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 589);
            this.panel3.TabIndex = 18;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.SystemColors.Control;
            this.metroTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroTile3.Location = new System.Drawing.Point(9, 51);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(214, 42);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "Только список лайкавших";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.BackColor = System.Drawing.SystemColors.Control;
            this.metroTile5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroTile5.Location = new System.Drawing.Point(9, 3);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(214, 42);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile5.TabIndex = 4;
            this.metroTile5.Text = "Вернуться к поиску";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile5.UseCustomForeColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.BackColor = System.Drawing.SystemColors.Control;
            this.metroTile6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroTile6.Location = new System.Drawing.Point(9, 98);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(214, 42);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile6.TabIndex = 5;
            this.metroTile6.Text = "Добавить подписчиков";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile6.UseCustomForeColor = true;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseTileImage = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.SystemColors.Control;
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroTile2.Location = new System.Drawing.Point(6, 24);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(200, 77);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile2.TabIndex = 0;
            this.metroTile2.Text = "Назад";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileImage = global::Data.Properties.Resources.back_icon1;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(457, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Все пользователи";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(281, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(533, 388);
            this.listBox1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(874, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Все пользователи";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(757, 55);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(292, 484);
            this.listBox2.TabIndex = 22;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroTile1.Location = new System.Drawing.Point(862, 540);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(190, 39);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 23;
            this.metroTile1.Text = "Вывести подробнее";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.BackColor = System.Drawing.SystemColors.Control;
            this.metroTile7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroTile7.Location = new System.Drawing.Point(9, 146);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(214, 42);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile7.TabIndex = 6;
            this.metroTile7.Text = "Добавить подписок";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile7.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile7.UseCustomForeColor = true;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.UseTileImage = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(245, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Общее кол-во лайков:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(457, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(603, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(245, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Кол-во пользователей, кто их ставил:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label9.Location = new System.Drawing.Point(245, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "Самый лайкающий профиль:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label10.Location = new System.Drawing.Point(514, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = ":";
            // 
            // ShowDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.textBox1);
            this.Name = "ShowDataControl";
            this.Size = new System.Drawing.Size(1052, 616);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.Label label5;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

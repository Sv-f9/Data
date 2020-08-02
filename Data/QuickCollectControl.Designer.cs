namespace Data
{
    partial class QuickCollectControl
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
            this.label4 = new System.Windows.Forms.Label();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Данный сбор не затратен по времени.";
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroTile4.Location = new System.Drawing.Point(7, 236);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(150, 45);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile4.TabIndex = 17;
            this.metroTile4.Text = "Остановить";
            this.metroTile4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile4.UseCustomForeColor = true;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseStyleColors = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click_1);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroTile3.Location = new System.Drawing.Point(7, 236);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(150, 45);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile3.TabIndex = 16;
            this.metroTile3.Text = "Запустить";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseStyleColors = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 287);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(546, 33);
            this.progressBar1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Введите ссылку или ник профиля ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textBox1.Location = new System.Drawing.Point(7, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 28);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(801, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Программа в данном режиме собирает только основную информацию о пользователе,";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(3, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(671, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "При досрочном завершении вся собранная информация будет записана.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Быстрый сбор";
            // 
            // QuickCollectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "QuickCollectControl";
            this.Size = new System.Drawing.Size(876, 534);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

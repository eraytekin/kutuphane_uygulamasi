namespace kutuphane_uygulamasi
{
    partial class uye_ekle_sil_sayfasi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.customer_box = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customer_name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.customer_surname_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.customer_number_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.add_button = new Guna.UI2.WinForms.Guna2Button();
            this.delete_button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye Ekle/Sil";
            // 
            // customer_box
            // 
            this.customer_box.BackColor = System.Drawing.Color.White;
            this.customer_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customer_box.ForeColor = System.Drawing.SystemColors.MenuText;
            this.customer_box.FormattingEnabled = true;
            this.customer_box.Location = new System.Drawing.Point(21, 28);
            this.customer_box.Name = "customer_box";
            this.customer_box.Size = new System.Drawing.Size(282, 325);
            this.customer_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon No";
            // 
            // customer_name_textbox
            // 
            this.customer_name_textbox.Animated = true;
            this.customer_name_textbox.AutoRoundedCorners = true;
            this.customer_name_textbox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.customer_name_textbox.BackColor = System.Drawing.Color.Transparent;
            this.customer_name_textbox.BorderRadius = 11;
            this.customer_name_textbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.customer_name_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customer_name_textbox.DefaultText = "";
            this.customer_name_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customer_name_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customer_name_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customer_name_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customer_name_textbox.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.customer_name_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.customer_name_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customer_name_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.customer_name_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.customer_name_textbox.Location = new System.Drawing.Point(378, 60);
            this.customer_name_textbox.MaxLength = 30;
            this.customer_name_textbox.Name = "customer_name_textbox";
            this.customer_name_textbox.PasswordChar = '\0';
            this.customer_name_textbox.PlaceholderText = "";
            this.customer_name_textbox.SelectedText = "";
            this.customer_name_textbox.Size = new System.Drawing.Size(200, 24);
            this.customer_name_textbox.TabIndex = 10;
            // 
            // customer_surname_textbox
            // 
            this.customer_surname_textbox.Animated = true;
            this.customer_surname_textbox.AutoRoundedCorners = true;
            this.customer_surname_textbox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.customer_surname_textbox.BackColor = System.Drawing.Color.Transparent;
            this.customer_surname_textbox.BorderRadius = 11;
            this.customer_surname_textbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.customer_surname_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customer_surname_textbox.DefaultText = "";
            this.customer_surname_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customer_surname_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customer_surname_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customer_surname_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customer_surname_textbox.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.customer_surname_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.customer_surname_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customer_surname_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.customer_surname_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.customer_surname_textbox.Location = new System.Drawing.Point(378, 112);
            this.customer_surname_textbox.MaxLength = 30;
            this.customer_surname_textbox.Name = "customer_surname_textbox";
            this.customer_surname_textbox.PasswordChar = '\0';
            this.customer_surname_textbox.PlaceholderText = "";
            this.customer_surname_textbox.SelectedText = "";
            this.customer_surname_textbox.Size = new System.Drawing.Size(200, 24);
            this.customer_surname_textbox.TabIndex = 10;
            // 
            // customer_number_textbox
            // 
            this.customer_number_textbox.Animated = true;
            this.customer_number_textbox.AutoRoundedCorners = true;
            this.customer_number_textbox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.customer_number_textbox.BackColor = System.Drawing.Color.Transparent;
            this.customer_number_textbox.BorderRadius = 11;
            this.customer_number_textbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.customer_number_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customer_number_textbox.DefaultText = "";
            this.customer_number_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customer_number_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customer_number_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customer_number_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customer_number_textbox.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.customer_number_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.customer_number_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customer_number_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.customer_number_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.customer_number_textbox.Location = new System.Drawing.Point(378, 167);
            this.customer_number_textbox.MaxLength = 10;
            this.customer_number_textbox.Name = "customer_number_textbox";
            this.customer_number_textbox.PasswordChar = '\0';
            this.customer_number_textbox.PlaceholderText = "";
            this.customer_number_textbox.SelectedText = "";
            this.customer_number_textbox.Size = new System.Drawing.Size(200, 24);
            this.customer_number_textbox.TabIndex = 10;
            this.customer_number_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customer_number_textbox_KeyPress);
            // 
            // add_button
            // 
            this.add_button.Animated = true;
            this.add_button.AutoRoundedCorners = true;
            this.add_button.BackColor = System.Drawing.Color.Transparent;
            this.add_button.BorderRadius = 10;
            this.add_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(403, 208);
            this.add_button.Name = "add_button";
            this.add_button.ShadowDecoration.Depth = 5;
            this.add_button.ShadowDecoration.Enabled = true;
            this.add_button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.add_button.Size = new System.Drawing.Size(72, 23);
            this.add_button.TabIndex = 15;
            this.add_button.Text = "Üye Ekle";
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Animated = true;
            this.delete_button.AutoRoundedCorners = true;
            this.delete_button.BackColor = System.Drawing.Color.Transparent;
            this.delete_button.BorderRadius = 10;
            this.delete_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_button.FillColor = System.Drawing.Color.Red;
            this.delete_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(481, 208);
            this.delete_button.Name = "delete_button";
            this.delete_button.ShadowDecoration.Depth = 5;
            this.delete_button.ShadowDecoration.Enabled = true;
            this.delete_button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.delete_button.Size = new System.Drawing.Size(72, 23);
            this.delete_button.TabIndex = 15;
            this.delete_button.Text = "Üye Sil";
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.customer_box);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(33, 32);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.G360400081A33240D0117.G2303131B14360D260C130E240B0C19;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(322, 368);
            this.guna2ShadowPanel1.TabIndex = 16;
            // 
            // uye_ekle_sil_sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.customer_number_textbox);
            this.Controls.Add(this.customer_surname_textbox);
            this.Controls.Add(this.customer_name_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uye_ekle_sil_sayfasi";
            this.Size = new System.Drawing.Size(841, 564);
            this.Load += new System.EventHandler(this.uye_ekle_sil_sayfasi_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox customer_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox customer_name_textbox;
        private Guna.UI2.WinForms.Guna2TextBox customer_surname_textbox;
        private Guna.UI2.WinForms.Guna2TextBox customer_number_textbox;
        private Guna.UI2.WinForms.Guna2Button add_button;
        private Guna.UI2.WinForms.Guna2Button delete_button;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    }
}

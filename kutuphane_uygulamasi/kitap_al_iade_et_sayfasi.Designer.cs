namespace kutuphane_uygulamasi
{
    partial class kitap_al_iade_et_sayfasi
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.get_delete_box = new System.Windows.Forms.ListBox();
            this.get_book_name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.get_customer_name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.get_customer_number_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.get_customer_surname_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kitap_ekle_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.get_urun_durum_combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Al/İade Et";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.get_delete_box);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(33, 32);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.G360400081A33240D0117.G2303131B14360D260C130E240B0C19;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(322, 368);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // get_delete_box
            // 
            this.get_delete_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.get_delete_box.FormattingEnabled = true;
            this.get_delete_box.Location = new System.Drawing.Point(21, 28);
            this.get_delete_box.Name = "get_delete_box";
            this.get_delete_box.Size = new System.Drawing.Size(282, 312);
            this.get_delete_box.TabIndex = 2;
            // 
            // get_book_name_textbox
            // 
            this.get_book_name_textbox.Animated = true;
            this.get_book_name_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.get_book_name_textbox.BorderRadius = 11;
            this.get_book_name_textbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.get_book_name_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.get_book_name_textbox.DefaultText = "";
            this.get_book_name_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.get_book_name_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.get_book_name_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.get_book_name_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.get_book_name_textbox.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.get_book_name_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.get_book_name_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.get_book_name_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.get_book_name_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.get_book_name_textbox.Location = new System.Drawing.Point(378, 60);
            this.get_book_name_textbox.MaxLength = 30;
            this.get_book_name_textbox.Name = "get_book_name_textbox";
            this.get_book_name_textbox.PasswordChar = '\0';
            this.get_book_name_textbox.PlaceholderText = "";
            this.get_book_name_textbox.SelectedText = "";
            this.get_book_name_textbox.Size = new System.Drawing.Size(200, 24);
            this.get_book_name_textbox.TabIndex = 4;
            // 
            // get_customer_name_textbox
            // 
            this.get_customer_name_textbox.Animated = true;
            this.get_customer_name_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.get_customer_name_textbox.BorderRadius = 11;
            this.get_customer_name_textbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.get_customer_name_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.get_customer_name_textbox.DefaultText = "";
            this.get_customer_name_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.get_customer_name_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.get_customer_name_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.get_customer_name_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.get_customer_name_textbox.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.get_customer_name_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.get_customer_name_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.get_customer_name_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.get_customer_name_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.get_customer_name_textbox.Location = new System.Drawing.Point(378, 112);
            this.get_customer_name_textbox.MaxLength = 30;
            this.get_customer_name_textbox.Name = "get_customer_name_textbox";
            this.get_customer_name_textbox.PasswordChar = '\0';
            this.get_customer_name_textbox.PlaceholderText = "";
            this.get_customer_name_textbox.SelectedText = "";
            this.get_customer_name_textbox.Size = new System.Drawing.Size(200, 24);
            this.get_customer_name_textbox.TabIndex = 4;
            // 
            // get_customer_number_textbox
            // 
            this.get_customer_number_textbox.Animated = true;
            this.get_customer_number_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.get_customer_number_textbox.BorderRadius = 11;
            this.get_customer_number_textbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.get_customer_number_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.get_customer_number_textbox.DefaultText = "";
            this.get_customer_number_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.get_customer_number_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.get_customer_number_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.get_customer_number_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.get_customer_number_textbox.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.get_customer_number_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.get_customer_number_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.get_customer_number_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.get_customer_number_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.get_customer_number_textbox.Location = new System.Drawing.Point(378, 224);
            this.get_customer_number_textbox.MaxLength = 10;
            this.get_customer_number_textbox.Name = "get_customer_number_textbox";
            this.get_customer_number_textbox.PasswordChar = '\0';
            this.get_customer_number_textbox.PlaceholderText = "";
            this.get_customer_number_textbox.SelectedText = "";
            this.get_customer_number_textbox.Size = new System.Drawing.Size(200, 24);
            this.get_customer_number_textbox.TabIndex = 4;
            this.get_customer_number_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.get_customer_number_textbox_KeyPress);
            // 
            // get_customer_surname_textbox
            // 
            this.get_customer_surname_textbox.Animated = true;
            this.get_customer_surname_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.get_customer_surname_textbox.BorderRadius = 11;
            this.get_customer_surname_textbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.get_customer_surname_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.get_customer_surname_textbox.DefaultText = "";
            this.get_customer_surname_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.get_customer_surname_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.get_customer_surname_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.get_customer_surname_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.get_customer_surname_textbox.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.get_customer_surname_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.get_customer_surname_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.get_customer_surname_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.get_customer_surname_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.get_customer_surname_textbox.Location = new System.Drawing.Point(378, 167);
            this.get_customer_surname_textbox.MaxLength = 30;
            this.get_customer_surname_textbox.Name = "get_customer_surname_textbox";
            this.get_customer_surname_textbox.PasswordChar = '\0';
            this.get_customer_surname_textbox.PlaceholderText = "";
            this.get_customer_surname_textbox.SelectedText = "";
            this.get_customer_surname_textbox.Size = new System.Drawing.Size(200, 24);
            this.get_customer_surname_textbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Müşteri Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Müşteri Soyadı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Müşteri Telefon Numarası";
            // 
            // kitap_ekle_btn
            // 
            this.kitap_ekle_btn.Animated = true;
            this.kitap_ekle_btn.AutoRoundedCorners = true;
            this.kitap_ekle_btn.BackColor = System.Drawing.Color.Transparent;
            this.kitap_ekle_btn.BorderRadius = 10;
            this.kitap_ekle_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kitap_ekle_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kitap_ekle_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kitap_ekle_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kitap_ekle_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kitap_ekle_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kitap_ekle_btn.ForeColor = System.Drawing.Color.White;
            this.kitap_ekle_btn.Location = new System.Drawing.Point(394, 329);
            this.kitap_ekle_btn.Name = "kitap_ekle_btn";
            this.kitap_ekle_btn.ShadowDecoration.Depth = 5;
            this.kitap_ekle_btn.ShadowDecoration.Enabled = true;
            this.kitap_ekle_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.kitap_ekle_btn.Size = new System.Drawing.Size(84, 23);
            this.kitap_ekle_btn.TabIndex = 9;
            this.kitap_ekle_btn.Text = "Kayıt Ekle";
            this.kitap_ekle_btn.Click += new System.EventHandler(this.kitap_ekle_btn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(484, 329);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Depth = 5;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Button1.Size = new System.Drawing.Size(84, 23);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "Kayıt Sil";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // get_urun_durum_combobox
            // 
            this.get_urun_durum_combobox.BackColor = System.Drawing.Color.Transparent;
            this.get_urun_durum_combobox.BorderRadius = 11;
            this.get_urun_durum_combobox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.get_urun_durum_combobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get_urun_durum_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.get_urun_durum_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.get_urun_durum_combobox.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.get_urun_durum_combobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.get_urun_durum_combobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.get_urun_durum_combobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.get_urun_durum_combobox.ForeColor = System.Drawing.Color.DimGray;
            this.get_urun_durum_combobox.ItemHeight = 30;
            this.get_urun_durum_combobox.Items.AddRange(new object[] {
            "Alındı",
            "İade Edildi"});
            this.get_urun_durum_combobox.Location = new System.Drawing.Point(378, 276);
            this.get_urun_durum_combobox.Name = "get_urun_durum_combobox";
            this.get_urun_durum_combobox.Size = new System.Drawing.Size(200, 36);
            this.get_urun_durum_combobox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kitap Durumu";
            // 
            // kitap_al_iade_et_sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.get_urun_durum_combobox);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.kitap_ekle_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.get_customer_surname_textbox);
            this.Controls.Add(this.get_customer_number_textbox);
            this.Controls.Add(this.get_customer_name_textbox);
            this.Controls.Add(this.get_book_name_textbox);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.label1);
            this.Name = "kitap_al_iade_et_sayfasi";
            this.Size = new System.Drawing.Size(841, 564);
            this.Load += new System.EventHandler(this.kitap_al_iade_et_sayfasi_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.ListBox get_delete_box;
        private Guna.UI2.WinForms.Guna2TextBox get_book_name_textbox;
        private Guna.UI2.WinForms.Guna2TextBox get_customer_name_textbox;
        private Guna.UI2.WinForms.Guna2TextBox get_customer_number_textbox;
        private Guna.UI2.WinForms.Guna2TextBox get_customer_surname_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button kitap_ekle_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox get_urun_durum_combobox;
        private System.Windows.Forms.Label label6;
    }
}

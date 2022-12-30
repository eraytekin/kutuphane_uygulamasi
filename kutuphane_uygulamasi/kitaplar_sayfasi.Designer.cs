namespace kutuphane_uygulamasi
{
    partial class kitaplar_sayfasi
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
            this.book_box = new System.Windows.Forms.ListBox();
            this.book_name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yazar_adi_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sayfa_sayisi_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kitap_turu_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.kitap_ekle_btn = new Guna.UI2.WinForms.Guna2Button();
            this.kitap_sil_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitaplar";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.book_box);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(33, 32);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.G360400081A33240D0117.G2303131B14360D260C130E240B0C19;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(322, 368);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // book_box
            // 
            this.book_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.book_box.FormattingEnabled = true;
            this.book_box.Location = new System.Drawing.Point(21, 28);
            this.book_box.Name = "book_box";
            this.book_box.Size = new System.Drawing.Size(282, 312);
            this.book_box.TabIndex = 0;
            // 
            // book_name_textbox
            // 
            this.book_name_textbox.Animated = true;
            this.book_name_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.book_name_textbox.BorderRadius = 11;
            this.book_name_textbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.book_name_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.book_name_textbox.DefaultText = "";
            this.book_name_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.book_name_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.book_name_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.book_name_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.book_name_textbox.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.book_name_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.book_name_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.book_name_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.book_name_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.book_name_textbox.Location = new System.Drawing.Point(378, 60);
            this.book_name_textbox.MaxLength = 30;
            this.book_name_textbox.Name = "book_name_textbox";
            this.book_name_textbox.PasswordChar = '\0';
            this.book_name_textbox.PlaceholderText = "";
            this.book_name_textbox.SelectedText = "";
            this.book_name_textbox.Size = new System.Drawing.Size(200, 24);
            this.book_name_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kitap Adı";
            // 
            // yazar_adi_textbox
            // 
            this.yazar_adi_textbox.Animated = true;
            this.yazar_adi_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.yazar_adi_textbox.BorderRadius = 11;
            this.yazar_adi_textbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.yazar_adi_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yazar_adi_textbox.DefaultText = "";
            this.yazar_adi_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.yazar_adi_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.yazar_adi_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yazar_adi_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yazar_adi_textbox.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.yazar_adi_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.yazar_adi_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.yazar_adi_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.yazar_adi_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.yazar_adi_textbox.Location = new System.Drawing.Point(378, 112);
            this.yazar_adi_textbox.MaxLength = 30;
            this.yazar_adi_textbox.Name = "yazar_adi_textbox";
            this.yazar_adi_textbox.PasswordChar = '\0';
            this.yazar_adi_textbox.PlaceholderText = "";
            this.yazar_adi_textbox.SelectedText = "";
            this.yazar_adi_textbox.Size = new System.Drawing.Size(200, 24);
            this.yazar_adi_textbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yazar Adı";
            // 
            // sayfa_sayisi_textbox
            // 
            this.sayfa_sayisi_textbox.Animated = true;
            this.sayfa_sayisi_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.sayfa_sayisi_textbox.BorderRadius = 11;
            this.sayfa_sayisi_textbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.sayfa_sayisi_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sayfa_sayisi_textbox.DefaultText = "";
            this.sayfa_sayisi_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sayfa_sayisi_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sayfa_sayisi_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sayfa_sayisi_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sayfa_sayisi_textbox.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.sayfa_sayisi_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.sayfa_sayisi_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sayfa_sayisi_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.sayfa_sayisi_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.sayfa_sayisi_textbox.Location = new System.Drawing.Point(378, 167);
            this.sayfa_sayisi_textbox.MaxLength = 30;
            this.sayfa_sayisi_textbox.Name = "sayfa_sayisi_textbox";
            this.sayfa_sayisi_textbox.PasswordChar = '\0';
            this.sayfa_sayisi_textbox.PlaceholderText = "";
            this.sayfa_sayisi_textbox.SelectedText = "";
            this.sayfa_sayisi_textbox.Size = new System.Drawing.Size(200, 24);
            this.sayfa_sayisi_textbox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kitap Türü";
            // 
            // kitap_turu_textbox
            // 
            this.kitap_turu_textbox.Animated = true;
            this.kitap_turu_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.kitap_turu_textbox.BorderRadius = 11;
            this.kitap_turu_textbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.kitap_turu_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kitap_turu_textbox.DefaultText = "";
            this.kitap_turu_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kitap_turu_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kitap_turu_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kitap_turu_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kitap_turu_textbox.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.kitap_turu_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.kitap_turu_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kitap_turu_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.kitap_turu_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.kitap_turu_textbox.Location = new System.Drawing.Point(378, 224);
            this.kitap_turu_textbox.MaxLength = 30;
            this.kitap_turu_textbox.Name = "kitap_turu_textbox";
            this.kitap_turu_textbox.PasswordChar = '\0';
            this.kitap_turu_textbox.PlaceholderText = "";
            this.kitap_turu_textbox.SelectedText = "";
            this.kitap_turu_textbox.Size = new System.Drawing.Size(200, 24);
            this.kitap_turu_textbox.TabIndex = 3;
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
            this.kitap_ekle_btn.Location = new System.Drawing.Point(394, 271);
            this.kitap_ekle_btn.Name = "kitap_ekle_btn";
            this.kitap_ekle_btn.ShadowDecoration.Depth = 5;
            this.kitap_ekle_btn.ShadowDecoration.Enabled = true;
            this.kitap_ekle_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.kitap_ekle_btn.Size = new System.Drawing.Size(84, 23);
            this.kitap_ekle_btn.TabIndex = 5;
            this.kitap_ekle_btn.Text = "Kitap Ekle";
            this.kitap_ekle_btn.Click += new System.EventHandler(this.kitap_ekle_btn_Click);
            // 
            // kitap_sil_btn
            // 
            this.kitap_sil_btn.Animated = true;
            this.kitap_sil_btn.AutoRoundedCorners = true;
            this.kitap_sil_btn.BackColor = System.Drawing.Color.Transparent;
            this.kitap_sil_btn.BorderRadius = 10;
            this.kitap_sil_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kitap_sil_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kitap_sil_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kitap_sil_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kitap_sil_btn.FillColor = System.Drawing.Color.Red;
            this.kitap_sil_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kitap_sil_btn.ForeColor = System.Drawing.Color.White;
            this.kitap_sil_btn.Location = new System.Drawing.Point(484, 271);
            this.kitap_sil_btn.Name = "kitap_sil_btn";
            this.kitap_sil_btn.ShadowDecoration.Depth = 5;
            this.kitap_sil_btn.ShadowDecoration.Enabled = true;
            this.kitap_sil_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.kitap_sil_btn.Size = new System.Drawing.Size(84, 23);
            this.kitap_sil_btn.TabIndex = 5;
            this.kitap_sil_btn.Text = "Kitap Sil";
            this.kitap_sil_btn.Click += new System.EventHandler(this.kitap_sil_btn_Click);
            // 
            // kitaplar_sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.kitap_sil_btn);
            this.Controls.Add(this.kitap_ekle_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kitap_turu_textbox);
            this.Controls.Add(this.sayfa_sayisi_textbox);
            this.Controls.Add(this.yazar_adi_textbox);
            this.Controls.Add(this.book_name_textbox);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.label1);
            this.Name = "kitaplar_sayfasi";
            this.Size = new System.Drawing.Size(841, 564);
            this.Load += new System.EventHandler(this.kitaplar_sayfasi_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox book_name_textbox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox yazar_adi_textbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox sayfa_sayisi_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox kitap_turu_textbox;
        private Guna.UI2.WinForms.Guna2Button kitap_ekle_btn;
        private Guna.UI2.WinForms.Guna2Button kitap_sil_btn;
        private System.Windows.Forms.ListBox book_box;
    }
}

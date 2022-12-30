namespace kutuphane_uygulamasi
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uye_ekle_sil = new FontAwesome.Sharp.IconButton();
            this.kitaplar_btn = new FontAwesome.Sharp.IconButton();
            this.kitap_al_iadeet = new FontAwesome.Sharp.IconButton();
            this.kitaplar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimalize_button = new FontAwesome.Sharp.IconButton();
            this.close_button = new FontAwesome.Sharp.IconButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.uye_ekle_sil_sayfasi2 = new kutuphane_uygulamasi.uye_ekle_sil_sayfasi();
            this.kitap_al_iade_et_sayfasi2 = new kutuphane_uygulamasi.kitap_al_iade_et_sayfasi();
            this.kitaplar_sayfasi2 = new kutuphane_uygulamasi.kitaplar_sayfasi();
            this.kitap_al_iade_et_sayfasi1 = new kutuphane_uygulamasi.kitap_al_iade_et_sayfasi();
            this.kitaplar_sayfasi1 = new kutuphane_uygulamasi.kitaplar_sayfasi();
            this.uye_ekle_sil_sayfasi1 = new kutuphane_uygulamasi.uye_ekle_sil_sayfasi();
            this.bos_sayfa1 = new kutuphane_uygulamasi.bos_sayfa();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.uye_ekle_sil);
            this.panel1.Controls.Add(this.kitaplar_btn);
            this.panel1.Controls.Add(this.kitap_al_iadeet);
            this.panel1.Controls.Add(this.kitaplar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 608);
            this.panel1.TabIndex = 0;
            // 
            // uye_ekle_sil
            // 
            this.uye_ekle_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uye_ekle_sil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.uye_ekle_sil.FlatAppearance.BorderSize = 0;
            this.uye_ekle_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uye_ekle_sil.ForeColor = System.Drawing.Color.White;
            this.uye_ekle_sil.IconChar = FontAwesome.Sharp.IconChar.User;
            this.uye_ekle_sil.IconColor = System.Drawing.Color.White;
            this.uye_ekle_sil.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.uye_ekle_sil.IconSize = 18;
            this.uye_ekle_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uye_ekle_sil.Location = new System.Drawing.Point(0, 262);
            this.uye_ekle_sil.Name = "uye_ekle_sil";
            this.uye_ekle_sil.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.uye_ekle_sil.Size = new System.Drawing.Size(213, 46);
            this.uye_ekle_sil.TabIndex = 2;
            this.uye_ekle_sil.Text = "Üye Ekle/Sil";
            this.uye_ekle_sil.UseVisualStyleBackColor = true;
            this.uye_ekle_sil.Click += new System.EventHandler(this.uye_ekle_sil_Click);
            // 
            // kitaplar_btn
            // 
            this.kitaplar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitaplar_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.kitaplar_btn.FlatAppearance.BorderSize = 0;
            this.kitaplar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitaplar_btn.ForeColor = System.Drawing.Color.White;
            this.kitaplar_btn.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.kitaplar_btn.IconColor = System.Drawing.Color.White;
            this.kitaplar_btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.kitaplar_btn.IconSize = 18;
            this.kitaplar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitaplar_btn.Location = new System.Drawing.Point(0, 158);
            this.kitaplar_btn.Name = "kitaplar_btn";
            this.kitaplar_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.kitaplar_btn.Size = new System.Drawing.Size(213, 46);
            this.kitaplar_btn.TabIndex = 2;
            this.kitaplar_btn.Text = "Kitaplar";
            this.kitaplar_btn.UseVisualStyleBackColor = true;
            this.kitaplar_btn.Click += new System.EventHandler(this.kitaplar_btn_Click);
            // 
            // kitap_al_iadeet
            // 
            this.kitap_al_iadeet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitap_al_iadeet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.kitap_al_iadeet.FlatAppearance.BorderSize = 0;
            this.kitap_al_iadeet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitap_al_iadeet.ForeColor = System.Drawing.Color.White;
            this.kitap_al_iadeet.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.kitap_al_iadeet.IconColor = System.Drawing.Color.White;
            this.kitap_al_iadeet.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.kitap_al_iadeet.IconSize = 18;
            this.kitap_al_iadeet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitap_al_iadeet.Location = new System.Drawing.Point(0, 210);
            this.kitap_al_iadeet.Name = "kitap_al_iadeet";
            this.kitap_al_iadeet.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.kitap_al_iadeet.Size = new System.Drawing.Size(213, 46);
            this.kitap_al_iadeet.TabIndex = 2;
            this.kitap_al_iadeet.Text = "Kitap Al/İade Et";
            this.kitap_al_iadeet.UseVisualStyleBackColor = true;
            this.kitap_al_iadeet.Click += new System.EventHandler(this.kitap_al_iadeet_Click);
            // 
            // kitaplar
            // 
            this.kitaplar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.kitaplar.IconColor = System.Drawing.Color.Black;
            this.kitaplar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kitaplar.Location = new System.Drawing.Point(0, 0);
            this.kitaplar.Name = "kitaplar";
            this.kitaplar.Size = new System.Drawing.Size(75, 23);
            this.kitaplar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(47, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "KÜTÜPHANE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.minimalize_button);
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 26);
            this.panel2.TabIndex = 1;
            // 
            // minimalize_button
            // 
            this.minimalize_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimalize_button.FlatAppearance.BorderSize = 0;
            this.minimalize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalize_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.minimalize_button.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimalize_button.IconColor = System.Drawing.Color.White;
            this.minimalize_button.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.minimalize_button.IconSize = 13;
            this.minimalize_button.Location = new System.Drawing.Point(980, -4);
            this.minimalize_button.Name = "minimalize_button";
            this.minimalize_button.Size = new System.Drawing.Size(42, 30);
            this.minimalize_button.TabIndex = 2;
            this.minimalize_button.UseVisualStyleBackColor = true;
            this.minimalize_button.Click += new System.EventHandler(this.minimalize_button_Click);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Red;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.Color.Red;
            this.close_button.IconChar = FontAwesome.Sharp.IconChar.X;
            this.close_button.IconColor = System.Drawing.Color.White;
            this.close_button.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.close_button.IconSize = 13;
            this.close_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.close_button.Location = new System.Drawing.Point(1024, -4);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(49, 30);
            this.close_button.TabIndex = 3;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // uye_ekle_sil_sayfasi2
            // 
            this.uye_ekle_sil_sayfasi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.uye_ekle_sil_sayfasi2.Location = new System.Drawing.Point(213, 27);
            this.uye_ekle_sil_sayfasi2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.uye_ekle_sil_sayfasi2.Name = "uye_ekle_sil_sayfasi2";
            this.uye_ekle_sil_sayfasi2.Size = new System.Drawing.Size(1495, 965);
            this.uye_ekle_sil_sayfasi2.TabIndex = 7;
            // 
            // kitap_al_iade_et_sayfasi2
            // 
            this.kitap_al_iade_et_sayfasi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.kitap_al_iade_et_sayfasi2.Location = new System.Drawing.Point(213, 27);
            this.kitap_al_iade_et_sayfasi2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.kitap_al_iade_et_sayfasi2.Name = "kitap_al_iade_et_sayfasi2";
            this.kitap_al_iade_et_sayfasi2.Size = new System.Drawing.Size(1495, 965);
            this.kitap_al_iade_et_sayfasi2.TabIndex = 6;
            // 
            // kitaplar_sayfasi2
            // 
            this.kitaplar_sayfasi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.kitaplar_sayfasi2.Location = new System.Drawing.Point(213, 27);
            this.kitaplar_sayfasi2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.kitaplar_sayfasi2.Name = "kitaplar_sayfasi2";
            this.kitaplar_sayfasi2.Size = new System.Drawing.Size(1495, 965);
            this.kitaplar_sayfasi2.TabIndex = 5;
            // 
            // kitap_al_iade_et_sayfasi1
            // 
            this.kitap_al_iade_et_sayfasi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.kitap_al_iade_et_sayfasi1.Location = new System.Drawing.Point(32720, 14317);
            this.kitap_al_iade_et_sayfasi1.Margin = new System.Windows.Forms.Padding(2759, 1950, 2759, 1950);
            this.kitap_al_iade_et_sayfasi1.Name = "kitap_al_iade_et_sayfasi1";
            this.kitap_al_iade_et_sayfasi1.Size = new System.Drawing.Size(65535, 65535);
            this.kitap_al_iade_et_sayfasi1.TabIndex = 4;
            // 
            // kitaplar_sayfasi1
            // 
            this.kitaplar_sayfasi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.kitaplar_sayfasi1.Location = new System.Drawing.Point(32720, 14317);
            this.kitaplar_sayfasi1.Margin = new System.Windows.Forms.Padding(2759, 1950, 2759, 1950);
            this.kitaplar_sayfasi1.Name = "kitaplar_sayfasi1";
            this.kitaplar_sayfasi1.Size = new System.Drawing.Size(65535, 65535);
            this.kitaplar_sayfasi1.TabIndex = 3;
            // 
            // uye_ekle_sil_sayfasi1
            // 
            this.uye_ekle_sil_sayfasi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.uye_ekle_sil_sayfasi1.Location = new System.Drawing.Point(32720, 14317);
            this.uye_ekle_sil_sayfasi1.Margin = new System.Windows.Forms.Padding(8720, 5703, 8720, 5703);
            this.uye_ekle_sil_sayfasi1.Name = "uye_ekle_sil_sayfasi1";
            this.uye_ekle_sil_sayfasi1.Size = new System.Drawing.Size(65535, 65535);
            this.uye_ekle_sil_sayfasi1.TabIndex = 2;
            // 
            // bos_sayfa1
            // 
            this.bos_sayfa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.bos_sayfa1.Location = new System.Drawing.Point(213, 27);
            this.bos_sayfa1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bos_sayfa1.Name = "bos_sayfa1";
            this.bos_sayfa1.Size = new System.Drawing.Size(841, 564);
            this.bos_sayfa1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1072, 608);
            this.Controls.Add(this.bos_sayfa1);
            this.Controls.Add(this.uye_ekle_sil_sayfasi2);
            this.Controls.Add(this.kitap_al_iade_et_sayfasi2);
            this.Controls.Add(this.kitaplar_sayfasi2);
            this.Controls.Add(this.kitap_al_iade_et_sayfasi1);
            this.Controls.Add(this.kitaplar_sayfasi1);
            this.Controls.Add(this.uye_ekle_sil_sayfasi1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton minimalize_button;
        private FontAwesome.Sharp.IconButton close_button;
        private FontAwesome.Sharp.IconButton uye_ekle_sil;
        private FontAwesome.Sharp.IconButton kitap_al_iadeet;
        private FontAwesome.Sharp.IconButton kitaplar;
        private FontAwesome.Sharp.IconButton kitaplar_btn;
        private uye_ekle_sil_sayfasi uye_ekle_sil_sayfasi1;
        private kitaplar_sayfasi kitaplar_sayfasi1;
        private kitap_al_iade_et_sayfasi kitap_al_iade_et_sayfasi1;
        public Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private uye_ekle_sil_sayfasi uye_ekle_sil_sayfasi2;
        private kitap_al_iade_et_sayfasi kitap_al_iade_et_sayfasi2;
        private kitaplar_sayfasi kitaplar_sayfasi2;
        private bos_sayfa bos_sayfa1;
    }
}


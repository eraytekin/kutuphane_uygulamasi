using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_uygulamasi
{
    public partial class kitaplar_sayfasi : UserControl
    {
        public kitaplar_sayfasi()
        {
            InitializeComponent();
        }
        private void kitaplar_sayfasi_Load(object sender, EventArgs e)
        {
            book_box.SelectionMode = SelectionMode.MultiExtended;
        }
        string book_name;
        string yazar_adi;
        string sayfa_sayisi;
        string kitap_turu;

        private void kitap_ekle_btn_Click(object sender, EventArgs e)
        {
            if (book_name_textbox.Text == "" || yazar_adi_textbox.Text == "" || sayfa_sayisi_textbox.Text == "" || kitap_turu_textbox.Text == "")
            {
                MessageBox.Show("Lütfen Boş Veri Girişi Yapmayınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                book_name = book_name_textbox.Text;
                yazar_adi = yazar_adi_textbox.Text;
                sayfa_sayisi = sayfa_sayisi_textbox.Text;
                kitap_turu = kitap_turu_textbox.Text;

                book_box.Items.Add(String.Join(" / ", book_name, yazar_adi, sayfa_sayisi, kitap_turu));

                book_name_textbox.Text = "";
                yazar_adi_textbox.Text = "";
                sayfa_sayisi_textbox.Text = "";
                kitap_turu_textbox.Text = "";
            }
        }

        private void kitap_sil_btn_Click(object sender, EventArgs e)
        {
            book_box.Items.Remove(book_box.SelectedItem);

            book_name_textbox.Text = "";
            yazar_adi_textbox.Text = "";
            sayfa_sayisi_textbox.Text = "";
            kitap_turu_textbox.Text = "";
        }

        private void sayfa_sayisi_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

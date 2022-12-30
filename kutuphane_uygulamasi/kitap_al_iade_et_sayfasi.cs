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
    public partial class kitap_al_iade_et_sayfasi : UserControl
    {
        public kitap_al_iade_et_sayfasi()
        {
            InitializeComponent();
        }
        private void kitap_al_iade_et_sayfasi_Load(object sender, EventArgs e)
        {
            get_delete_box.SelectionMode = SelectionMode.MultiExtended;
        }

        string get_book_name;
        string get_customer_name;
        string get_customer_surname;
        string get_customer_number;
        string get_urun_durum;

        private void kitap_ekle_btn_Click(object sender, EventArgs e)
        {
            if (get_book_name_textbox.Text == "" || get_customer_name_textbox.Text == "" || get_customer_surname_textbox.Text == "" || get_customer_number_textbox.Text == "" || get_urun_durum_combobox.Text == "")
            {
                MessageBox.Show("Lütfen Boş Veri Girişi Yapmayınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                get_book_name = get_book_name_textbox.Text;
                get_customer_name = get_customer_name_textbox.Text;
                get_customer_surname = get_customer_surname_textbox.Text;
                get_customer_number = get_customer_number_textbox.Text;
                get_urun_durum = get_urun_durum_combobox.Text;

                get_delete_box.Items.Add(String.Join(" / ", get_book_name, get_customer_name, get_customer_surname, get_customer_number, get_urun_durum));

                get_book_name_textbox.Text = "";
                get_customer_name_textbox.Text = "";
                get_customer_surname_textbox.Text = "";
                get_customer_number_textbox.Text = "";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            get_delete_box.Items.Remove(get_delete_box.SelectedItem);

            get_book_name_textbox.Text = "";
            get_customer_name_textbox.Text = "";
            get_customer_surname_textbox.Text = "";
            get_customer_number_textbox.Text = "";
        }

        private void get_customer_number_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_uygulamasi
{
    public partial class uye_ekle_sil_sayfasi : UserControl
    {
        public uye_ekle_sil_sayfasi()
        {
            InitializeComponent();
        }
        private void uye_ekle_sil_sayfasi_Load(object sender, EventArgs e)
        {
            customer_box.SelectionMode = SelectionMode.MultiExtended;
        }

        string customer_name;
        string customer_surname;
        string customer_number;


        private void add_button_Click(object sender, EventArgs e)
        {
            if (customer_name_textbox.Text == "" || customer_surname_textbox.Text == "" || customer_number_textbox.Text == "")
            {
                MessageBox.Show("Lütfen Boş Veri Girişi Yapmayınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                customer_name = customer_name_textbox.Text;
                customer_surname = customer_surname_textbox.Text;
                customer_number = customer_number_textbox.Text;

                customer_box.Items.Add(String.Join(" / ", customer_name, customer_surname, customer_number));

                customer_name_textbox.Text = "";
                customer_surname_textbox.Text = "";
                customer_number_textbox.Text = "";
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            customer_box.Items.Remove(customer_box.SelectedItem);

            customer_name_textbox.Text = "";
            customer_surname_textbox.Text = "";
            customer_number_textbox.Text = "";
        }
    }
}

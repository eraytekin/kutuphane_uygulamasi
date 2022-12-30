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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kitaplar_sayfasi3.BringToFront();
        }
        private void minimalize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kitaplar_btn_Click(object sender, EventArgs e)
        {
            kitaplar_sayfasi3.BringToFront();
        }

        private void uye_ekle_sil_Click(object sender, EventArgs e)
        {
            uye_ekle_sil_sayfasi3.BringToFront();
        }

        private void kitap_al_iadeet_Click(object sender, EventArgs e)
        {
            kitap_al_iade_et_sayfasi3.BringToFront();
        }

        
    }
}

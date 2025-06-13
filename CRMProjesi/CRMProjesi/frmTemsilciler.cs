using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp4.Data;

namespace WindowsFormsApp4
{
    public partial class frmTemsilciler : Form
    {
        public frmTemsilciler()
        {
            InitializeComponent();
            GridYenile(dgvTemsilciler, DataStore.Temsilciler);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var t = new Temsilci
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text
            };
            DataStore.Temsilciler.Add(t);
            GridYenile(dgvTemsilciler, DataStore.Temsilciler);
            GirdileriTemizle(txtAd, txtSoyad);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvTemsilciler.CurrentRow == null) return;
            var sec = (Temsilci)dgvTemsilciler.CurrentRow.DataBoundItem;
            DataStore.Temsilciler.Remove(sec);
            GridYenile(dgvTemsilciler, DataStore.Temsilciler);
            GirdileriTemizle(txtAd, txtSoyad);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            GirdileriTemizle(txtAd, txtSoyad);
        }

        private void GridYenile<T>(DataGridView dgv, List<T> liste)
        {
            dgv.DataSource = null;
            dgv.DataSource = liste;
        }

        private void GirdileriTemizle(params Control[] kontroller)
        {
            foreach (var ctl in kontroller)
            {
                if (ctl is TextBox txt) txt.Clear();
                else if (ctl is ComboBox cb) cb.SelectedIndex = -1;
            }
            dgvTemsilciler.ClearSelection();
        }
    }
}

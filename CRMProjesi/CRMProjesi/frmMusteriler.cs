using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Data;

namespace WindowsFormsApp4
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
            dgvMusteriler.AutoGenerateColumns = false;
            dgvMusteriler.DataSource = null;
            dgvMusteriler.AllowUserToAddRows = false;

            cmbTemsilci.DataSource = DataStore.Temsilciler;
            cmbTemsilci.DisplayMember = "Ad";
            cmbTemsilci.ValueMember = "Id";

            RefreshGrid();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            cmbTemsilci.DataSource = DataStore.Temsilciler;
            cmbTemsilci.DisplayMember = "Ad";
            cmbTemsilci.ValueMember = "Id";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var m = new Musteri
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTelefon.Text,
                Email = txtEmail.Text,
                TemsilciID = (Guid)cmbTemsilci.SelectedValue
            };
            DataStore.Musteriler.Add(m);

            ClearInputs();
            RefreshGrid();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow == null) return;
            var sec = (Musteri)dgvMusteriler.CurrentRow.Tag;
            DataStore.Musteriler.Remove(sec);

            ClearInputs();
            RefreshGrid();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
        private void RefreshGrid()
        {
            dgvMusteriler.DataSource = null;
            dgvMusteriler.Rows.Clear();

            foreach (var m in DataStore.Musteriler)
            {
                int idx = dgvMusteriler.Rows.Add();
                var row = dgvMusteriler.Rows[idx];

                row.Cells["colAd"].Value = m.Ad;
                row.Cells["colSoyad"].Value = m.Soyad;
                row.Cells["colTelefon"].Value = m.Telefon;
                row.Cells["colEmail"].Value = m.Email;

                var rep = DataStore.Temsilciler
                           .FirstOrDefault(r => r.Id == m.TemsilciID);
                row.Cells["colTemsilci"].Value = rep?.Ad ?? "(seçili değil)";

                row.Tag = m;
            }
            if (dgvMusteriler.Rows.Count == 0)
                dgvMusteriler.CurrentCell = null;
            else
                dgvMusteriler.ClearSelection();
        }
        private void ClearInputs()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            cmbTemsilci.SelectedIndex = -1;
            dgvMusteriler.ClearSelection();
        }

    }
}

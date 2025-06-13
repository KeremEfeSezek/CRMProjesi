using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp4.Data;

namespace WindowsFormsApp4
{
    public partial class frmTalepler : Form
    {
        public frmTalepler()
        {
            InitializeComponent();
            dgvTalepler.AutoGenerateColumns = false;
            dgvTalepler.DataSource = null;
            dgvTalepler.AllowUserToAddRows = false;
            dgvTalepler.RowHeadersVisible = false;

            cmbMusteri.DataSource = DataStore.Musteriler;
            cmbMusteri.DisplayMember = "Ad";
            cmbMusteri.ValueMember = "Id";

            cmbTemsilci.DataSource = DataStore.Temsilciler;
            cmbTemsilci.DisplayMember = "Ad";
            cmbTemsilci.ValueMember = "Id";

            dgvTalepler.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;

                var row = dgvTalepler.Rows[e.RowIndex];
                if (row.Tag is Talep t)
                {
                    txtKonu.Text = t.Konu;
                  
                    rtbDetay.Text = t.Detay;
                 
                    cmbMusteri.SelectedValue = t.MusteriID;
                 
                    cmbTemsilci.SelectedValue = t.TemsilciID;
                }
            };

            RefreshGrid();

            dgvTalepler.SelectionChanged += dgvTalepler_SelectionChanged;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKonu.Text)) return;

            var t = new Talep
            {
                Konu = txtKonu.Text,
                Detay = rtbDetay.Text,        
                MusteriID = (Guid)cmbMusteri.SelectedValue,
                TemsilciID = (Guid)cmbTemsilci.SelectedValue
            };
            DataStore.Talepler.Add(t);

            ClearInputs();
            RefreshGrid();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvTalepler.CurrentRow == null) return;
            var sec = (Talep)dgvTalepler.CurrentRow.Tag;
            DataStore.Talepler.Remove(sec);

            ClearInputs();
            RefreshGrid();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dgvTalepler_SelectionChanged(object sender, EventArgs e)
        {
            var row = dgvTalepler.CurrentRow;
            if (row == null)
                return;

            var t = row.Tag as Talep;
            if (t == null)
                return;

            txtKonu.Text = t.Konu;
            cmbMusteri.SelectedValue = t.MusteriID;
            cmbTemsilci.SelectedValue = t.TemsilciID;
        }

        private void RefreshGrid()
        {
            dgvTalepler.Rows.Clear();

            foreach (var t in DataStore.Talepler)
            {
                var musteri = DataStore.Musteriler.FirstOrDefault(m => m.Id == t.MusteriID);
                var temsilci = DataStore.Temsilciler.FirstOrDefault(r => r.Id == t.TemsilciID);

                int idx = dgvTalepler.Rows.Add();
                var row = dgvTalepler.Rows[idx];

                row.Cells["colKonu"].Value = t.Konu;
                row.Cells["colDetay"].Value = t.Detay;
                row.Cells["colMusteri"].Value = musteri?.Ad ?? "(bilinmiyor)";
                row.Cells["colTemsilci"].Value = temsilci?.Ad ?? "(bilinmiyor)";

                row.Tag = t;
            }
        }

        private void ClearInputs()
        {
            txtKonu.Clear();
            rtbDetay.Clear();   
            cmbMusteri.SelectedIndex = -1;
            cmbTemsilci.SelectedIndex = -1;
            dgvTalepler.ClearSelection();
        }
    }
}

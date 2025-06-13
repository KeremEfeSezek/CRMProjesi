using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp4.Data;

namespace WindowsFormsApp4
{
    public partial class frmGeriBildirimler : Form
    {
        public frmGeriBildirimler()
        {
            InitializeComponent();
            dgvGeriBildirimler.AutoGenerateColumns = false;
            dgvGeriBildirimler.AllowUserToAddRows = false;
            dgvGeriBildirimler.Columns.Clear();
            dgvGeriBildirimler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMetin",
                HeaderText = "Metin"
            });
            dgvGeriBildirimler.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colTamamlandi",
                HeaderText = "Tamamlandı"
            });

            dgvGeriBildirimler.CurrentCell = null;
            dgvGeriBildirimler.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == dgvGeriBildirimler.Columns["colTamamlandi"].Index
                    && e.RowIndex >= 0)
                {
                    dgvGeriBildirimler.CommitEdit(
                        DataGridViewDataErrorContexts.Commit);
                }
            };

            dgvGeriBildirimler.CellValueChanged += (sender, e) =>
            {
                if (e.ColumnIndex == dgvGeriBildirimler.Columns["colTamamlandi"].Index
                    && e.RowIndex >= 0)
                {
                    var row = dgvGeriBildirimler.Rows[e.RowIndex];
                    if (row.Tag is GeriBildirim fb)
                    {
                        fb.Tamamlandı = (bool)row.Cells["colTamamlandi"].Value;
                    }
                }
            };


            RefreshGrid();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
      
            if (string.IsNullOrWhiteSpace(txtMetin.Text)) return;

            var fb = new GeriBildirim
            {
                MusteriId = Guid.Empty,
                Metin = txtMetin.Text,
                Tamamlandı = chkTamamlandi.Checked
            };
            DataStore.GeriBildirimler.Add(fb);

            RefreshGrid();
            ClearInputs();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
       
            var row = dgvGeriBildirimler.CurrentRow;
            if (row == null) return;


            if (row.Tag is GeriBildirim fb)
            {

                DataStore.GeriBildirimler.Remove(fb);
    
                RefreshGrid();
                
                ClearInputs();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void RefreshGrid()
        {
            dgvGeriBildirimler.Rows.Clear();

            foreach (var fb in DataStore.GeriBildirimler)
            {
                int idx = dgvGeriBildirimler.Rows.Add();
                var row = dgvGeriBildirimler.Rows[idx];
                row.Cells["colMetin"].Value = fb.Metin;
                row.Cells["colTamamlandi"].Value = fb.Tamamlandı;
                row.Tag = fb;
            }

            if (dgvGeriBildirimler.Rows.Count == 0)
                dgvGeriBildirimler.CurrentCell = null;
            else
                dgvGeriBildirimler.ClearSelection();
        }

   
        private void ClearInputs()
        {
            txtMetin.Clear();
            chkTamamlandi.Checked = false;

            dgvGeriBildirimler.ClearSelection();

            dgvGeriBildirimler.CurrentCell = null;
        }

        private void frmGeriBildirimler_Load(object sender, EventArgs e)
        {
            if (dgvGeriBildirimler.Columns.Contains("MusteriId"))
                dgvGeriBildirimler.Columns["MusteriId"].Visible = false;
        }
    }
}

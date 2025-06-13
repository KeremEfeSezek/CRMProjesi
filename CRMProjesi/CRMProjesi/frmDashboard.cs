using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsApp4.Data;
namespace WindowsFormsApp4
{
    public partial class frmDashboard : Form
    {
       
        public frmDashboard()
        {
            InitializeComponent();


        }
        private void RefreshGrid<T>(DataGridView grid, List<T> list)
        {
            grid.DataSource = null;
            grid.DataSource = list;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblTotalCustomers.Text = DataStore.Musteriler.Count.ToString();
            lblTotalRequests.Text = DataStore.Talepler.Count.ToString();
            lblTotalReps.Text = DataStore.Temsilciler.Count.ToString();
            lblPendingFeedback.Text = DataStore.GeriBildirimler.Count(f => !f.Tamamlandı).ToString();
        }
    }
}

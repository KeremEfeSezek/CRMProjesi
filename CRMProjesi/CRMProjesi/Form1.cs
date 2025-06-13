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
namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(218, 218, 218);

            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock= DockStyle.Fill, TopLevel=false, TopMost=true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnMusteriler.Height;
            PnlNav.Top = btnMusteriler.Top;
            PnlNav.Left = btnMusteriler.Left;
            btnMusteriler.BackColor = Color.FromArgb(218, 218, 218);
            lblTitle.Text = "Müşteriler";
            this.PnlFormLoader.Controls.Clear();
            frmMusteriler FrmDashboard_Vrb = new frmMusteriler() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnTalepler_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnTalepler.Height;
            PnlNav.Top = btnTalepler.Top;
            PnlNav.Left = btnTalepler.Left;
            btnTalepler.BackColor = Color.FromArgb(218, 218, 218);
            lblTitle.Text = "Talepler";
            this.PnlFormLoader.Controls.Clear();
            frmTalepler FrmDashboard_Vrb = new frmTalepler() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnTemsilciler_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnTemsilciler.Height;
            PnlNav.Top = btnTemsilciler.Top;
            PnlNav.Left = btnTemsilciler.Left;
            btnTemsilciler.BackColor = Color.FromArgb(218, 218, 218);
            lblTitle.Text = "Temsilciler";
            this.PnlFormLoader.Controls.Clear();
            frmTemsilciler FrmDashboard_Vrb = new frmTemsilciler() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnGeriBildirimler_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnGeriBildirimler.Height;
            PnlNav.Top = btnGeriBildirimler.Top;
            PnlNav.Left = btnGeriBildirimler.Left;
            btnGeriBildirimler.BackColor = Color.FromArgb(218, 218, 218);
            lblTitle.Text = "Geri Bildirimler";
            this.PnlFormLoader.Controls.Clear();
            frmGeriBildirimler FrmDashboard_Vrb = new frmGeriBildirimler() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void btnMusteriler_Leave(object sender, EventArgs e)
        {
            btnMusteriler.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void btnTalepler_Leave(object sender, EventArgs e)
        {
            btnTalepler.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void btnTemsilciler_Leave(object sender, EventArgs e)
        {
            btnTemsilciler.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void btnGeriBildirimler_Leave(object sender, EventArgs e)
        {
            btnGeriBildirimler.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}

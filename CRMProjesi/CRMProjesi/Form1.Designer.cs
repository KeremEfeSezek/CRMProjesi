namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.btnGeriBildirimler = new System.Windows.Forms.Button();
            this.btnTemsilciler = new System.Windows.Forms.Button();
            this.btnTalepler = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1316, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Noto Sans", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblTitle.Location = new System.Drawing.Point(285, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 53);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Dashboard";
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 0);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(22, 135);
            this.PnlNav.TabIndex = 1;
            // 
            // btnGeriBildirimler
            // 
            this.btnGeriBildirimler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnGeriBildirimler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeriBildirimler.FlatAppearance.BorderSize = 0;
            this.btnGeriBildirimler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriBildirimler.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriBildirimler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnGeriBildirimler.Location = new System.Drawing.Point(0, 540);
            this.btnGeriBildirimler.Name = "btnGeriBildirimler";
            this.btnGeriBildirimler.Size = new System.Drawing.Size(279, 135);
            this.btnGeriBildirimler.TabIndex = 4;
            this.btnGeriBildirimler.Text = "Geri Bildirimler";
            this.btnGeriBildirimler.UseVisualStyleBackColor = false;
            this.btnGeriBildirimler.Click += new System.EventHandler(this.btnGeriBildirimler_Click);
            this.btnGeriBildirimler.Leave += new System.EventHandler(this.btnGeriBildirimler_Leave);
            // 
            // btnTemsilciler
            // 
            this.btnTemsilciler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnTemsilciler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTemsilciler.FlatAppearance.BorderSize = 0;
            this.btnTemsilciler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemsilciler.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemsilciler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTemsilciler.Location = new System.Drawing.Point(0, 405);
            this.btnTemsilciler.Name = "btnTemsilciler";
            this.btnTemsilciler.Size = new System.Drawing.Size(279, 135);
            this.btnTemsilciler.TabIndex = 3;
            this.btnTemsilciler.Text = "Temsilciler";
            this.btnTemsilciler.UseVisualStyleBackColor = false;
            this.btnTemsilciler.Click += new System.EventHandler(this.btnTemsilciler_Click);
            this.btnTemsilciler.Leave += new System.EventHandler(this.btnTemsilciler_Leave);
            // 
            // btnTalepler
            // 
            this.btnTalepler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnTalepler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTalepler.FlatAppearance.BorderSize = 0;
            this.btnTalepler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalepler.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTalepler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTalepler.Location = new System.Drawing.Point(0, 270);
            this.btnTalepler.Name = "btnTalepler";
            this.btnTalepler.Size = new System.Drawing.Size(279, 135);
            this.btnTalepler.TabIndex = 2;
            this.btnTalepler.Text = "Talepler";
            this.btnTalepler.UseVisualStyleBackColor = false;
            this.btnTalepler.Click += new System.EventHandler(this.btnTalepler_Click);
            this.btnTalepler.Leave += new System.EventHandler(this.btnTalepler_Leave);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnMusteriler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusteriler.FlatAppearance.BorderSize = 0;
            this.btnMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriler.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnMusteriler.Location = new System.Drawing.Point(0, 135);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(279, 135);
            this.btnMusteriler.TabIndex = 1;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = false;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            this.btnMusteriler.Leave += new System.EventHandler(this.btnMusteriler_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(279, 135);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.btnGeriBildirimler);
            this.panel1.Controls.Add(this.btnTemsilciler);
            this.panel1.Controls.Add(this.btnTalepler);
            this.panel1.Controls.Add(this.btnMusteriler);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 849);
            this.panel1.TabIndex = 6;
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(279, 115);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(1099, 734);
            this.PnlFormLoader.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1378, 849);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Button btnGeriBildirimler;
        private System.Windows.Forms.Button btnTemsilciler;
        private System.Windows.Forms.Button btnTalepler;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlFormLoader;
    }
}
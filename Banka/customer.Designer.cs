namespace Banka
{
    partial class customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            this.labelİsim = new System.Windows.Forms.Label();
            this.labelHesapNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBilgi = new System.Windows.Forms.Button();
            this.btnHesap = new System.Windows.Forms.Button();
            this.btnSifre = new System.Windows.Forms.Button();
            this.btnEft = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelİsim
            // 
            this.labelİsim.AutoSize = true;
            this.labelİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelİsim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelİsim.Location = new System.Drawing.Point(68, 83);
            this.labelİsim.Name = "labelİsim";
            this.labelİsim.Size = new System.Drawing.Size(40, 20);
            this.labelİsim.TabIndex = 7;
            this.labelİsim.Text = "İsim";
            // 
            // labelHesapNo
            // 
            this.labelHesapNo.AutoSize = true;
            this.labelHesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHesapNo.ForeColor = System.Drawing.Color.White;
            this.labelHesapNo.Location = new System.Drawing.Point(104, 113);
            this.labelHesapNo.Name = "labelHesapNo";
            this.labelHesapNo.Size = new System.Drawing.Size(79, 20);
            this.labelHesapNo.TabIndex = 7;
            this.labelHesapNo.Text = "HesapNo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnBilgi);
            this.panel1.Controls.Add(this.btnHesap);
            this.panel1.Controls.Add(this.btnSifre);
            this.panel1.Controls.Add(this.btnEft);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnParaCek);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 10;
            // 
            // btnBilgi
            // 
            this.btnBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBilgi.FlatAppearance.BorderSize = 0;
            this.btnBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilgi.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBilgi.Image = ((System.Drawing.Image)(resources.GetObject("btnBilgi.Image")));
            this.btnBilgi.Location = new System.Drawing.Point(0, 459);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(186, 62);
            this.btnBilgi.TabIndex = 11;
            this.btnBilgi.Text = "Hesap Bilgileri";
            this.btnBilgi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBilgi.UseVisualStyleBackColor = true;
            this.btnBilgi.Click += new System.EventHandler(this.button3_Click);
            this.btnBilgi.Leave += new System.EventHandler(this.btnBilgi_Leave);
            // 
            // btnHesap
            // 
            this.btnHesap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHesap.FlatAppearance.BorderSize = 0;
            this.btnHesap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesap.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHesap.Image = ((System.Drawing.Image)(resources.GetObject("btnHesap.Image")));
            this.btnHesap.Location = new System.Drawing.Point(0, 397);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(186, 62);
            this.btnHesap.TabIndex = 10;
            this.btnHesap.Text = "Hesap Hareketleri";
            this.btnHesap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click_1);
            this.btnHesap.Leave += new System.EventHandler(this.btnHesap_Leave);
            // 
            // btnSifre
            // 
            this.btnSifre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSifre.FlatAppearance.BorderSize = 0;
            this.btnSifre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifre.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSifre.Image = ((System.Drawing.Image)(resources.GetObject("btnSifre.Image")));
            this.btnSifre.Location = new System.Drawing.Point(0, 355);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(186, 42);
            this.btnSifre.TabIndex = 9;
            this.btnSifre.Text = "Şifre Değiştir";
            this.btnSifre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSifre.UseVisualStyleBackColor = true;
            this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click_1);
            this.btnSifre.Leave += new System.EventHandler(this.btnSifre_Leave);
            // 
            // btnEft
            // 
            this.btnEft.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEft.FlatAppearance.BorderSize = 0;
            this.btnEft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEft.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEft.Image = ((System.Drawing.Image)(resources.GetObject("btnEft.Image")));
            this.btnEft.Location = new System.Drawing.Point(0, 288);
            this.btnEft.Name = "btnEft";
            this.btnEft.Size = new System.Drawing.Size(186, 67);
            this.btnEft.TabIndex = 8;
            this.btnEft.Text = "Havale / EFT";
            this.btnEft.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEft.UseVisualStyleBackColor = true;
            this.btnEft.Click += new System.EventHandler(this.btnEft_Click_1);
            this.btnEft.Leave += new System.EventHandler(this.btnEft_Leave);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Çıkış Yap";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            // 
            // btnParaCek
            // 
            this.btnParaCek.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParaCek.FlatAppearance.BorderSize = 0;
            this.btnParaCek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParaCek.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParaCek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnParaCek.Image = ((System.Drawing.Image)(resources.GetObject("btnParaCek.Image")));
            this.btnParaCek.Location = new System.Drawing.Point(0, 232);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(186, 56);
            this.btnParaCek.TabIndex = 4;
            this.btnParaCek.Text = "Para Çek / Yatır";
            this.btnParaCek.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaEkle_Click);
            this.btnParaCek.Leave += new System.EventHandler(this.btnParaCek_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(0, 190);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(186, 42);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Anasayfa";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBakiye);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelHesapNo);
            this.panel2.Controls.Add(this.labelİsim);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 190);
            this.panel2.TabIndex = 0;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.ForeColor = System.Drawing.Color.White;
            this.lblBakiye.Location = new System.Drawing.Point(104, 152);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(59, 20);
            this.lblBakiye.TabIndex = 10;
            this.lblBakiye.Text = "Bakiye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(5, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bakiye";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(5, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "HesapNo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(255, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 488);
            this.panel3.TabIndex = 13;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 238);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1195, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1237, 577);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelİsim;
        private System.Windows.Forms.Label labelHesapNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Button btnSifre;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBilgi;
    }
}
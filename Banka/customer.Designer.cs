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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnhesap = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnsifre = new System.Windows.Forms.Button();
            this.btnbakiye = new System.Windows.Forms.Button();
            this.btneft = new System.Windows.Forms.Button();
            this.btnparayatir = new System.Windows.Forms.Button();
            this.btnparacek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelİsim = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelHesapNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnhesap);
            this.groupBox1.Controls.Add(this.btncikis);
            this.groupBox1.Controls.Add(this.btnsifre);
            this.groupBox1.Controls.Add(this.btnbakiye);
            this.groupBox1.Controls.Add(this.btneft);
            this.groupBox1.Controls.Add(this.btnparayatir);
            this.groupBox1.Controls.Add(this.btnparacek);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(134, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 467);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // btnhesap
            // 
            this.btnhesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesap.Location = new System.Drawing.Point(94, 349);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(253, 32);
            this.btnhesap.TabIndex = 6;
            this.btnhesap.Text = "Hesap Hareketleri";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // btncikis
            // 
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.Color.Red;
            this.btncikis.Location = new System.Drawing.Point(94, 406);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(253, 44);
            this.btncikis.TabIndex = 5;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnsifre
            // 
            this.btnsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsifre.Location = new System.Drawing.Point(94, 293);
            this.btnsifre.Name = "btnsifre";
            this.btnsifre.Size = new System.Drawing.Size(253, 32);
            this.btnsifre.TabIndex = 4;
            this.btnsifre.Text = "Şifre Değiştir";
            this.btnsifre.UseVisualStyleBackColor = true;
            this.btnsifre.Click += new System.EventHandler(this.btnsifre_Click);
            // 
            // btnbakiye
            // 
            this.btnbakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbakiye.Location = new System.Drawing.Point(94, 167);
            this.btnbakiye.Name = "btnbakiye";
            this.btnbakiye.Size = new System.Drawing.Size(253, 32);
            this.btnbakiye.TabIndex = 3;
            this.btnbakiye.Text = "Bakiye Görüntüle";
            this.btnbakiye.UseVisualStyleBackColor = true;
            this.btnbakiye.Click += new System.EventHandler(this.btnbakiye_Click);
            // 
            // btneft
            // 
            this.btneft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btneft.Location = new System.Drawing.Point(94, 234);
            this.btneft.Name = "btneft";
            this.btneft.Size = new System.Drawing.Size(253, 32);
            this.btneft.TabIndex = 2;
            this.btneft.Text = "Havale / EFT";
            this.btneft.UseVisualStyleBackColor = true;
            this.btneft.Click += new System.EventHandler(this.btneft_Click);
            // 
            // btnparayatir
            // 
            this.btnparayatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnparayatir.Location = new System.Drawing.Point(94, 103);
            this.btnparayatir.Name = "btnparayatir";
            this.btnparayatir.Size = new System.Drawing.Size(253, 32);
            this.btnparayatir.TabIndex = 1;
            this.btnparayatir.Text = "Para Yatır";
            this.btnparayatir.UseVisualStyleBackColor = true;
            this.btnparayatir.Click += new System.EventHandler(this.btnparayatir_Click);
            // 
            // btnparacek
            // 
            this.btnparacek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnparacek.Location = new System.Drawing.Point(94, 34);
            this.btnparacek.Name = "btnparacek";
            this.btnparacek.Size = new System.Drawing.Size(253, 32);
            this.btnparacek.TabIndex = 0;
            this.btnparacek.Text = "Para Çek";
            this.btnparacek.UseVisualStyleBackColor = true;
            this.btnparacek.Click += new System.EventHandler(this.btnparacek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hoşgeldiniz Sayın";
            // 
            // labelİsim
            // 
            this.labelİsim.AutoSize = true;
            this.labelİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelİsim.ForeColor = System.Drawing.Color.Red;
            this.labelİsim.Location = new System.Drawing.Point(167, 18);
            this.labelİsim.Name = "labelİsim";
            this.labelİsim.Size = new System.Drawing.Size(40, 20);
            this.labelİsim.TabIndex = 7;
            this.labelİsim.Text = "İsim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelİsim);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(194, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 49);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelHesapNo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(194, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 49);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // labelHesapNo
            // 
            this.labelHesapNo.AutoSize = true;
            this.labelHesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHesapNo.ForeColor = System.Drawing.Color.Red;
            this.labelHesapNo.Location = new System.Drawing.Point(157, 18);
            this.labelHesapNo.Name = "labelHesapNo";
            this.labelHesapNo.Size = new System.Drawing.Size(79, 20);
            this.labelHesapNo.TabIndex = 7;
            this.labelHesapNo.Text = "HesapNo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(8, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hesap Numarası: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 707);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customer";
            this.Load += new System.EventHandler(this.customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnsifre;
        private System.Windows.Forms.Button btnbakiye;
        private System.Windows.Forms.Button btneft;
        private System.Windows.Forms.Button btnparayatir;
        private System.Windows.Forms.Button btnparacek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelİsim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelHesapNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnhesap;
    }
}

namespace HastaneRandevuEFCF_WinFormUI
{
    partial class FormDoktorlar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageListele = new System.Windows.Forms.TabPage();
            this.tabPageEkle = new System.Windows.Forms.TabPage();
            this.dataGridViewDoktor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDrTC = new System.Windows.Forms.TextBox();
            this.txtDrSoyad = new System.Windows.Forms.TextBox();
            this.txtDrAd = new System.Windows.Forms.TextBox();
            this.txtDrEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDrEkle = new System.Windows.Forms.Button();
            this.comboBoxDrBranslar = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxDrTel = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageListele.SuspendLayout();
            this.tabPageEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageListele);
            this.tabControl1.Controls.Add(this.tabPageEkle);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageListele
            // 
            this.tabPageListele.BackColor = System.Drawing.Color.OrangeRed;
            this.tabPageListele.Controls.Add(this.dataGridViewDoktor);
            this.tabPageListele.Location = new System.Drawing.Point(4, 25);
            this.tabPageListele.Name = "tabPageListele";
            this.tabPageListele.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListele.Size = new System.Drawing.Size(792, 458);
            this.tabPageListele.TabIndex = 0;
            this.tabPageListele.Text = "DR LİSTESİ";
            // 
            // tabPageEkle
            // 
            this.tabPageEkle.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageEkle.Controls.Add(this.maskedTextBoxDrTel);
            this.tabPageEkle.Controls.Add(this.comboBoxDrBranslar);
            this.tabPageEkle.Controls.Add(this.btnDrEkle);
            this.tabPageEkle.Controls.Add(this.label6);
            this.tabPageEkle.Controls.Add(this.txtDrEmail);
            this.tabPageEkle.Controls.Add(this.txtDrAd);
            this.tabPageEkle.Controls.Add(this.txtDrSoyad);
            this.tabPageEkle.Controls.Add(this.txtDrTC);
            this.tabPageEkle.Controls.Add(this.label5);
            this.tabPageEkle.Controls.Add(this.label4);
            this.tabPageEkle.Controls.Add(this.label3);
            this.tabPageEkle.Controls.Add(this.label2);
            this.tabPageEkle.Controls.Add(this.label1);
            this.tabPageEkle.Location = new System.Drawing.Point(4, 25);
            this.tabPageEkle.Name = "tabPageEkle";
            this.tabPageEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEkle.Size = new System.Drawing.Size(792, 458);
            this.tabPageEkle.TabIndex = 1;
            this.tabPageEkle.Text = "DR EKLE";
            // 
            // dataGridViewDoktor
            // 
            this.dataGridViewDoktor.AllowUserToAddRows = false;
            this.dataGridViewDoktor.AllowUserToDeleteRows = false;
            this.dataGridViewDoktor.AllowUserToOrderColumns = true;
            this.dataGridViewDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktor.Location = new System.Drawing.Point(21, 36);
            this.dataGridViewDoktor.Name = "dataGridViewDoktor";
            this.dataGridViewDoktor.ReadOnly = true;
            this.dataGridViewDoktor.RowHeadersWidth = 51;
            this.dataGridViewDoktor.RowTemplate.Height = 24;
            this.dataGridViewDoktor.Size = new System.Drawing.Size(748, 376);
            this.dataGridViewDoktor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(248, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(246, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(217, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(207, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(220, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // txtDrTC
            // 
            this.txtDrTC.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDrTC.Location = new System.Drawing.Point(288, 49);
            this.txtDrTC.Name = "txtDrTC";
            this.txtDrTC.Size = new System.Drawing.Size(258, 26);
            this.txtDrTC.TabIndex = 5;
            // 
            // txtDrSoyad
            // 
            this.txtDrSoyad.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDrSoyad.Location = new System.Drawing.Point(288, 161);
            this.txtDrSoyad.Name = "txtDrSoyad";
            this.txtDrSoyad.Size = new System.Drawing.Size(258, 26);
            this.txtDrSoyad.TabIndex = 6;
            // 
            // txtDrAd
            // 
            this.txtDrAd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDrAd.Location = new System.Drawing.Point(288, 105);
            this.txtDrAd.Name = "txtDrAd";
            this.txtDrAd.Size = new System.Drawing.Size(258, 26);
            this.txtDrAd.TabIndex = 7;
            // 
            // txtDrEmail
            // 
            this.txtDrEmail.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDrEmail.Location = new System.Drawing.Point(288, 324);
            this.txtDrEmail.Name = "txtDrEmail";
            this.txtDrEmail.Size = new System.Drawing.Size(258, 26);
            this.txtDrEmail.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(207, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Branş:";
            // 
            // btnDrEkle
            // 
            this.btnDrEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btnDrEkle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDrEkle.Location = new System.Drawing.Point(211, 372);
            this.btnDrEkle.Name = "btnDrEkle";
            this.btnDrEkle.Size = new System.Drawing.Size(335, 59);
            this.btnDrEkle.TabIndex = 11;
            this.btnDrEkle.Text = "YENİ DOKTOR EKLE";
            this.btnDrEkle.UseVisualStyleBackColor = false;
            this.btnDrEkle.Click += new System.EventHandler(this.btnDrEkle_Click);
            // 
            // comboBoxDrBranslar
            // 
            this.comboBoxDrBranslar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDrBranslar.FormattingEnabled = true;
            this.comboBoxDrBranslar.Location = new System.Drawing.Point(288, 212);
            this.comboBoxDrBranslar.Name = "comboBoxDrBranslar";
            this.comboBoxDrBranslar.Size = new System.Drawing.Size(258, 26);
            this.comboBoxDrBranslar.TabIndex = 12;
            this.comboBoxDrBranslar.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrBranslar_SelectedIndexChanged);
            // 
            // maskedTextBoxDrTel
            // 
            this.maskedTextBoxDrTel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxDrTel.Location = new System.Drawing.Point(288, 266);
            this.maskedTextBoxDrTel.Name = "maskedTextBoxDrTel";
            this.maskedTextBoxDrTel.Size = new System.Drawing.Size(258, 26);
            this.maskedTextBoxDrTel.TabIndex = 13;
            // 
            // FormDoktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDoktorlar";
            this.Text = "DOKTOR İŞLEMLERİ FORMU";
            this.Load += new System.EventHandler(this.FormDoktorlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageListele.ResumeLayout(false);
            this.tabPageEkle.ResumeLayout(false);
            this.tabPageEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageListele;
        private System.Windows.Forms.DataGridView dataGridViewDoktor;
        private System.Windows.Forms.TabPage tabPageEkle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDrTel;
        private System.Windows.Forms.ComboBox comboBoxDrBranslar;
        private System.Windows.Forms.Button btnDrEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDrEmail;
        private System.Windows.Forms.TextBox txtDrAd;
        private System.Windows.Forms.TextBox txtDrSoyad;
        private System.Windows.Forms.TextBox txtDrTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
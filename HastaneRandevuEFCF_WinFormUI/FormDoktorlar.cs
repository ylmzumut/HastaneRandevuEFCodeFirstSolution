using HastaneRandevuEFCF_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneRandevuEFCF_BLL;

namespace HastaneRandevuEFCF_WinFormUI
{
    public partial class FormDoktorlar : Form
    {
        public FormDoktorlar()
        {
            InitializeComponent();
        }
        //Global alan
        DoktorManager drManager = new DoktorManager();

        private void FormDoktorlar_Load(object sender, EventArgs e)
        {
            //datagrid
            DrGrideVerileriGetir();

            //comboBox
            comboBoxDrBranslar.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            //comboBoxDrBranslar.DisplayMember = "TheValue";
            //comboBoxDrBranslar.ValueMember = "TheKey";
            //comboBoxDrBranslar.DataSource = EnumManager.TumBranslariGetir();
            //comboBoxDrBranslar.SelectedValue = (int)Branslar.BransYok;

            comboBoxDrBranslar.DataSource = Enum.GetValues(typeof(Branslar));

            //maskedtextbox maske ayarlaması
            maskedTextBoxDrTel.Mask = @"\0\5##-###-##-##";//
        }
        private void btnDrEkle_Click(object sender, EventArgs e)
        {
            try
            {
                //kontrol edilmei gereken durumlar
                //ad-soyad en az 2 karaterde olmalı
                if (txtDrAd.Text.Trim().Length < 2)//Su
                {
                    throw new Exception("Lütfen doktor adını düzgün giriniz!");
                }
                if (txtDrSoyad.Text.Trim().Length < 2)//Ak
                {
                    throw new Exception("Lütfen doktor soyadını düzgün giriniz!");
                }
                //tc kimlik numarası
                if (txtDrTC.Text.Trim().Length != 11) //12345678960
                {
                    throw new Exception("TC Kimlik numarası 11 haneli olmalıdır!");
                }
                if (txtDrTC.Text.Any(x => !char.IsDigit(x)))
                {
                    throw new Exception("TC Kimlik numarası rakamlardan oluşacak şekilde 11 haneli olmalıdır!");
                }
                //char[] tc=txtDrTC.Text.ToCharArray();
                int b = Convert.ToInt32(txtDrTC.Text.Trim().Substring(txtDrTC.Text.Trim().Length - 1, 1));
                if (b % 2 != 0)
                {
                    throw new Exception("TC Kimlik numarasını yanlış girdiniz! Tek olamaz!");
                }

                //telefon

                Branslar drBransi;
                Enum.TryParse(comboBoxDrBranslar.SelectedValue.ToString(), out drBransi);
                Doktor yeniDoktor = new Doktor()
                {
                    DoktorAdi = txtDrAd.Text.Trim(),
                    DoktorSoyadi = txtDrSoyad.Text.Trim(),
                    Brans = drBransi,
                    Email = txtDrEmail.Text,
                    Telefon = maskedTextBoxDrTel.Text.Replace("-", ""),
                    TCNumarasi = txtDrTC.Text
                };
                //veritabanına ekleme yapmamız lazım
                if (drManager.YeniDoktorEkle(yeniDoktor))
                {
                    MessageBox.Show($"{txtDrAd.Text.Trim()} {txtDrSoyad.Text.Trim()} sisteme yeni doktorumuz olarak eklenmiştir!");
                    DrEkleSayfasiTemizle();
                    DrGrideVerileriGetir();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA: " + ex.Message);
            }

        }

        private void DrGrideVerileriGetir()
        {
            dataGridViewDoktor.DataSource = drManager.TumAktifDoktorlariGetir();
        }

        private void DrEkleSayfasiTemizle()
        {
            txtDrAd.Clear();
            txtDrSoyad.Clear();
            txtDrTC.Clear();
            txtDrEmail.Clear();
            maskedTextBoxDrTel.Clear();
            comboBoxDrBranslar.SelectedIndex = 0;
        }

        private void comboBoxDrBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}

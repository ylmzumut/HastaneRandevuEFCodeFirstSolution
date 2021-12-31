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
using HastaneRandevuEFCF_Entities;

namespace HastaneRandevuEFCF_WinFormUI
{
    public partial class FormHastaCagir : Form
    {
        public FormHastaCagir()
        {
            InitializeComponent();
        }
        //global alan
        DoktorManager drManager = new DoktorManager();
        RandevuManager rndManager = new RandevuManager();

        Doktor SecilenDoktor { get; set; }

        public bool FormLoadBittiMi { get; set; } = false;

        private void FormHastaCagir_Load(object sender, EventArgs e)
        {
            FormLoadBittiMi = false;
            //combo
            ComboyaDoktorlariGetir();
            //btnDurdur
            btnDurdur.Enabled = false;
            btnBasla.Enabled = true;
            //label
            labelHasta.Text = "------------------";
            SecilenDoktor = null;
            FormLoadBittiMi = true;
        }

        private void ComboyaDoktorlariGetir()
        {
            comboBoxDoktor.DisplayMember = "DoktorAdi" + "DoktorSoyadi";
            comboBoxDoktor.ValueMember = "DoktorID";
            comboBoxDoktor.DataSource = drManager.TumAktifDoktorlariGetir();
            comboBoxDoktor.SelectedIndex = -1;
        }

        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelHasta.Text = "---";
            if (comboBoxDoktor.SelectedIndex >= 0)
            {
                SecilenDoktor = drManager.DoktoruIDyeGoreBul(
                    (int)comboBoxDoktor.SelectedValue);

                // secilen doktorun  bugüne ait randevusu yoksa burada bir messagebox ile randevusu yoktur diye mesaj verilmelidir ve timer stop edilmelidir.

                if (rndManager.DoktorunRandevulariniTariheGoreGetir(SecilenDoktor, DateTime.Now).Count == 0 
                    &&
                    FormLoadBittiMi)

                {
                    MessageBox.Show($"{SecilenDoktor.ToString()} adlı doktorun bugün hiç randevusu bulunmuyor!");
                    timer1.Stop();
                    btnBasla.Enabled = true;
                    btnDurdur.Enabled = false;
                }
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 saniye verdik
            //1.yöntem
            timer1.Enabled = true;
            //2.yöntem  ---> 2side timerı çalıştırır.
            //timer1.Start();
            btnDurdur.Enabled = true;
            btnBasla.Enabled = false;
            comboBoxDoktor.Enabled = false;
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnDurdur.Enabled = false;
            btnBasla.Enabled = true;
            labelHasta.Font = new Font("Calibri", 35);
            comboBoxDoktor.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Font BuyukFont = new Font("Calibri", 45);
            Font NormalFont = new Font("Calibri", 35);

            if (SecilenDoktor!=null)
            {
                // Doktorun bugüne ait randevularını bulalım
                List<RandevuBilgileri> drRandevulari = rndManager.DoktorunRandevulariniTariheGoreGetir(SecilenDoktor, DateTime.Now);

                if (drRandevulari.Count>0)
                {
                    RandevuBilgileri bulunanRandevu = drRandevulari.FirstOrDefault(
                        x=>x.RandevuTarihi.ToString("HH")==DateTime.Now.Hour.ToString()
                        &&
                        x.RandevuTarihi.Minute<DateTime.Now.Minute+2
                        &&
                        x.RandevuTarihi.Minute>DateTime.Now.Minute-2
                        );
                    if (bulunanRandevu!=null)
                    {
                        labelHasta.Text = $"{bulunanRandevu.Hasta.HastaAdi} {bulunanRandevu.Hasta.HastaSoyadi}";

                        labelHasta.ForeColor = Color.Red;
                        if (DateTime.Now.Second % 2 == 0)
                        {
                            labelHasta.Font = BuyukFont;
                        }
                        else
                        {
                            labelHasta.Font = NormalFont;
                        }
                    }
                }
            }
        }
    }
}

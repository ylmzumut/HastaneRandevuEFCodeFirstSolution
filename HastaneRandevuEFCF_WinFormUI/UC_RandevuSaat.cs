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
    public partial class UC_RandevuSaat : UserControl
    {
        public UC_RandevuSaat()
        {
            InitializeComponent();
        }
        //Global alan
        public Doktor Doktorum { get; set; }
        public DateTime DisaridanGelenTarih { get; set; } = DateTime.Now;
        RandevuManager rndManger = new RandevuManager();
        public DateTime SecilenRandevuTarihi { get; set; }
        public bool RandevuAlabilirAktifMi { get; set; }
        private void UC_RandevuSaat_Load(object sender, EventArgs e)
        {
            RandevuAlabilirAktifMi = false;
            comboBoxSaatler.DisplayMember = "SaatDilimi";
            comboBoxSaatler.ValueMember = "ID";
            comboBoxSaatler.DataSource = SaatViewModel.SaatlerListesiniGetir();
            comboBoxSaatler.SelectedIndex = -1;
            RandevuButonlarinIsimleriniTemizle();
            //butonlara ortak click event verildi
            foreach (Button item in tableLayoutPanelRandevuButtonlar.Controls)
            {
                item.Click += new EventHandler(btnClick);
            }
            Doktorum = null;
            DRveTrhyeGoreButonlariniAktifPasifIslemleriniYap();

            timer1.Interval = 10;
            timer1.Enabled = true;
        }

        private void comboBoxSaatler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GecmisSaatlerinButonlariniPasiflestir();
                if (Doktorum == null)
                {
                    RandevuButonlariniPasiflestir();
                    return;
                }
                if (comboBoxSaatler.SelectedIndex >= 0)
                {
                    //Butonların textleri ayarlanacak
                    ButonlarınTextleriniAyarla();
                    //Butonların aktif ve pasifi ayarlanacak
                    DRveTrhyeGoreButonlariniAktifPasifIslemleriniYap();
                }
                else
                {
                    RandevuButonlarinIsimleriniTemizle();
                    RandevuButonlariniPasiflestir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }


        }

        private void DRveTrhyeGoreButonlariniAktifPasifIslemleriniYap()
        {
            try
            {
                RandevuButonlariniAktiflestir();
                if (Doktorum != null)
                {

                    //randevuları alalım
                    List<RandevuBilgileri> drRandevulari = rndManger.DoktorunRandevulariniTariheGoreGetir(Doktorum, DisaridanGelenTarih);
                    if (drRandevulari.Count > 0)
                    {
                        //o randevuları tek tek dolaşalım pasifleştirme işlemi yapalım
                        foreach (RandevuBilgileri item in drRandevulari)
                        {
                            if (item.RandevuTarihi.ToShortTimeString().Substring(0, 2) == comboBoxSaatler.Text.Substring(0, 2))
                            //10:00==10:00
                            {
                                string itemsaatim = item.RandevuTarihi.ToShortTimeString();
                                string itemdk = itemsaatim.Substring(3, 2);//sadece dakikayı aldık
                                switch (itemdk)
                                {
                                    case "00":
                                        btn00.Enabled = false;
                                        break;
                                    case "15":
                                        btn15.Enabled = false;
                                        break;
                                    case "30":
                                        btn30.Enabled = false;
                                        break;
                                    case "45":
                                        btn45.Enabled = false;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }

                }
                else
                {
                    RandevuButonlarinIsimleriniTemizle();
                    RandevuButonlariniPasiflestir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        private void ButonlarınTextleriniAyarla()
        {
            if (comboBoxSaatler.SelectedIndex >= 0)
            {
                string saatim = SaatViewModel.SaatlerListesiniGetir().FirstOrDefault(x => x.ID == (int)comboBoxSaatler.SelectedValue).SaatDilimi.Substring(0, 2);

                foreach (Button item in tableLayoutPanelRandevuButtonlar.Controls)
                {

                    switch (item.Name)
                    {
                        case "btn00":
                            btn00.Text = $"{saatim}:00";
                            break;
                        case "btn15":
                            btn15.Text = $"{saatim}:15";
                            break;
                        case "btn30":
                            btn30.Text = $"{saatim}:30";
                            break;
                        case "btn45":
                            btn45.Text = $"{saatim}:45";
                            break;
                        default:
                            item.Text = "---";
                            break;
                    }
                }
            }
            else
            {

            }
        }
        private void RandevuButonlariniAktiflestir()
        {
            foreach (Button item in tableLayoutPanelRandevuButtonlar.Controls)
            {
                item.Enabled = true;
            }
        }
        private void RandevuButonlariniPasiflestir()
        {
            foreach (Button item in tableLayoutPanelRandevuButtonlar.Controls)
            {
                item.Enabled = false;
            }
        }

        private void RandevuButonlarinIsimleriniTemizle()
        {
            foreach (Button item in tableLayoutPanelRandevuButtonlar.Controls)
            {
                item.Text = "---";
            }
        }


        private void btnClick(object sender, EventArgs e)
        {
            //tıklandığında randevu tarihi oluşacak
            Button btn = sender as Button;
            int saat = Convert.ToInt32(btn.Text.Substring(0, 2));
            int dakika = Convert.ToInt32(btn.Text.Substring(3, 2));
            SecilenRandevuTarihi = new DateTime(DisaridanGelenTarih.Year, DisaridanGelenTarih.Month, DisaridanGelenTarih.Day, saat, dakika, 00);
            RandevuAlabilirAktifMi = true;

        }

        public void Temizle()
        {
            RandevuButonlarinIsimleriniTemizle();
            RandevuButonlariniPasiflestir();
            comboBoxSaatler.SelectedIndex = -1;
            RandevuAlabilirAktifMi = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GecmisSaatlerinButonlariniPasiflestir();
        }

        private void GecmisSaatlerinButonlariniPasiflestir()
        {
            foreach (Button btnitem in tableLayoutPanelRandevuButtonlar.Controls)
            {
                //10:15
                int dakika = 0;
                int saat = 0;
                if (btnitem.Text.Length > 3)
                {
                    int.TryParse(btnitem.Text.Substring(3, 2), out dakika);
                    int.TryParse(btnitem.Text.Substring(0, 2), out saat);
                }

                if (DisaridanGelenTarih.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    if (saat < DateTime.Now.Hour)
                    {
                        btnitem.BackColor = Color.DarkGray;
                        btnitem.Enabled = false;
                    }
                    else if (saat == DateTime.Now.Hour)
                    {
                        if (dakika <= DateTime.Now.Minute)
                        {
                            btnitem.BackColor = Color.DarkGray;
                            btnitem.Enabled = false;
                        }
                    }
                }
            }
        }
    }
}

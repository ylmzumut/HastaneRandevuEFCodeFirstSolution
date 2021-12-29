﻿using HastaneRandevuEFCF_BLL;
using HastaneRandevuEFCF_Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HastaneRandevuEFCF_WinFormUI
{
    public partial class FormRandevuAlma : Form
    {
        public FormRandevuAlma()
        {
            InitializeComponent();
        }
        //Global alan
        HastaManager hastaManagerim = new HastaManager();
        DoktorManager doktorManagerim = new DoktorManager();
        RandevuManager rndManager = new RandevuManager();

        private void FormRandevuAlma_Load(object sender, EventArgs e)
        {
            //Servis groupBox ve TarihSaat groupBoxları pasif
            ServisGroupBoxiniPasiflestir();
            RandevuTarihveSaatGroupBoxiniPasiflestir();
            HastaListBoxiniDoldur();

            DateTimePickeriAyarla(DateTime.Now);

        }

        private void DateTimePickeriAyarla(DateTime trh)
        {
            dateTimePickerRandevuTarihi.Format = DateTimePickerFormat.Custom;
            dateTimePickerRandevuTarihi.CustomFormat = "dd.MM.yyyy";
            dateTimePickerRandevuTarihi.MinDate = DateTime.Now.AddMinutes(-1);
            dateTimePickerRandevuTarihi.MaxDate = dateTimePickerRandevuTarihi.Value.AddDays(15);
            dateTimePickerRandevuTarihi.Value = trh;

            //if (dateTimePickerRandevuTarihi.Text.Contains("Saturday"))
            //{
            //    MessageBox.Show("Cumartesi günü randevu alamazsınız!");
            //}
            //else if (dateTimePickerRandevuTarihi.Text.Contains("Sunday"))
            //{
            //    MessageBox.Show("Pazar günü randevu alamazsınız!");
            //}

            //DateTime dt = DateTime.Now.AddDays(1);
            //int nDays=0;
            //int weeks = nDays / 5;
            //nDays %= 5;
            //while (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
            //    dt = dt.AddDays(1);

            //while (nDays-- > 0)
            //{
            //    dt = dt.AddDays(1);
            //    if (dt.DayOfWeek == DayOfWeek.Saturday)
            //        dt = dt.AddDays(2);
            //}
            //dateTimePickerRandevuTarihi.MaxDate=dt.AddDays(weeks * 7);

        }

        private void HastaListBoxiniDoldur()
        {
            listBoxHastalar.DataSource = hastaManagerim.TumHastalarGetir();
            listBoxHastalar.SelectedIndex = -1;
        }

        private void RandevuTarihveSaatGroupBoxiniPasiflestir()
        {
            groupBoxRandevu.Enabled = false;
        }
        private void RandevuTarihveSaatGroupBoxiniAktifestir()
        {
            groupBoxRandevu.Enabled = true;
        }

        private void ServisGroupBoxiniPasiflestir()
        {
            groupBoxServis.Enabled = false;
        }

        private void txtHastaTCArama_TextChanged(object sender, EventArgs e)
        {
            if (txtHastaTCArama.Text.Trim().Length >= 2)
            {
                listBoxHastalar.DataSource = hastaManagerim.TcNumarasinaGoreHastayiBul(txtHastaTCArama.Text);
            }
            else
            {
                HastaListBoxiniDoldur();
            }
        }

        private void listBoxHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBoxHastalar.SelectedIndex >= 0)
            {
                ServisGroupBoxiniAktiflestir();
            }
            else
            {
                ServisGroupBoxiniPasiflestir();
                RandevuTarihveSaatGroupBoxiniPasiflestir();
            }
            DateTimePickeriAyarla(DateTime.Now);
            UC_RandevuSaat1.Temizle();
        }
        private void ServisGroupBoxiniAktiflestir()
        {
            groupBoxServis.Enabled = true;
            //servis combo dolmalı
            ComboBoxServisiDoldur();

        }
        private void ComboBoxServisiDoldur()
        {
            comboBoxServis.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxServis.DataSource = Enum.GetValues(typeof(Branslar));
            comboBoxServis.SelectedIndex = -1;
        }

        private void comboBoxServis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxServis.SelectedIndex >= 0)
            {
                Branslar drBransi;
                Enum.TryParse(comboBoxServis.SelectedValue.ToString(), out drBransi);
                listBoxDoktorlar.DataSource = doktorManagerim.BransaGoreDoktorlariGetir(drBransi);
            }
            else
            {
                listBoxDoktorlar.DataSource = null;
            }
            listBoxDoktorlar.SelectedIndex = -1;
            DateTimePickeriAyarla(DateTime.Now);
            UC_RandevuSaat1.Temizle();
        }

        private void listBoxDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTimePickeriAyarla(DateTime.Now);
            if (listBoxDoktorlar.SelectedIndex >= 0)
            {
                RandevuTarihveSaatGroupBoxiniAktifestir();
                Doktor seciliDr = listBoxDoktorlar.SelectedItem as Doktor;
                UC_RandevuSaat1.Doktorum = seciliDr;
            }
            else
            {
                RandevuTarihveSaatGroupBoxiniPasiflestir();
                UC_RandevuSaat1.Doktorum = null;
            }
        }

        private void dateTimePickerRandevuTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickeriAyarla(dateTimePickerRandevuTarihi.Value);
            UC_RandevuSaat1.DisaridanGelenTarih = dateTimePickerRandevuTarihi.Value;
            UC_RandevuSaat1.Temizle();
        }

        private void UC_RandevuSaat_Load(object sender, EventArgs e)
        {

        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxHastalar.SelectedIndex < 0)
                {
                    MessageBox.Show("Hasta seçemeden randevu işlemleri yapılamaz!");
                    return;
                }
                if (listBoxDoktorlar.SelectedIndex < 0)
                {
                    throw new Exception("Doktor seçmeden randevu alma işlemleri yapılamaz!");
                }
                if (!UC_RandevuSaat1.RandevuAlabilirAktifMi)
                {
                    MessageBox.Show("Randevu alabilmeniz için yukarıdaki randevu saati butonlarına tıklayarak saat seçmelisiniz!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                //Hastanın o tarihe o saate başka randevusu varsa alamaz.
                Hasta secilenHasta = listBoxHastalar.SelectedItem as Hasta;
                if (rndManager.HastaninSecilenTarihveSaatteRandevusuVarMi(secilenHasta, UC_RandevuSaat1.SecilenRandevuTarihi))
                {
                    MessageBox.Show($"Dikkat: {UC_RandevuSaat1.SecilenRandevuTarihi.ToString("dd.MM.yyyy HH:mm:ss")} başka bir randevunuz vardır. Bu nedenle aynı saate randevu alamazsınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //hasta randevusunu alabilir.
                Doktor secilenDoktor = listBoxDoktorlar.SelectedItem as Doktor;
                RandevuBilgileri yeniRandevu = new RandevuBilgileri()
                {
                    HastaID = secilenHasta.HastaID,
                    DoktorID=secilenDoktor.DoktorID,
                    RandevuTarihi=UC_RandevuSaat1.SecilenRandevuTarihi
                };
                bool rndAlindiMi = false;
                rndAlindiMi = rndManager.RandevuyuAl(yeniRandevu);
                if (rndAlindiMi)
                {
                    MessageBox.Show("RANDEVUNUZ ALINMIŞTIR","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //temizlik
                    UC_RandevuSaat1.Temizle();
                    dateTimePickerRandevuTarihi.Value = DateTime.Now;
                    RandevuTarihveSaatGroupBoxiniPasiflestir();
                    ServisGroupBoxiniPasiflestir();
                    listBoxHastalar.SelectedIndex = -1;
                }
                else
                {
                    throw new Exception("Randevu alma işleminde beklenmedik bir hata oluştu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }


    }
}

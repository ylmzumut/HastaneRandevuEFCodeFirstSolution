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

        private void UC_RandevuSaat_Load(object sender, EventArgs e)
        {
            comboBoxSaatler.DisplayMember = "SaatDilimi";
            comboBoxSaatler.ValueMember = "ID";
            comboBoxSaatler.DataSource = SaatViewModel.SaatlerListesiniGetir();
        }

        private void comboBoxSaatler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSaatler.SelectedIndex >= 0)
            {

                string saatim =
                      comboBoxSaatler.SelectedValue
                      .ToString(); //09:
                int saatim2 = Convert.ToInt32(comboBoxSaatler.SelectedValue.ToString())+1;

                foreach (Button item in tableLayoutPanelRandevuButtonlar.Controls)
                {
                    switch (item.Name)
                    {
                        case "btn0015":
                            btn0015.Text = $"{saatim}:00 - {saatim}:15";
                            break;
                        case "btn1530":
                            btn1530.Text = $"{saatim}:15 - {saatim}:30";
                            break;
                        case "btn3045":
                            btn3045.Text = $"{saatim}:30 - {saatim}:45";
                            break;
                        case "btn4500":
                            btn4500.Text = $"{saatim}:45 - {saatim2}:00";
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {

            }
        }
    }
}

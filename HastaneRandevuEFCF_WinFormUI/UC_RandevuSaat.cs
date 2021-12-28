using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneRandevuEFCF_WinFormUI;


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
            comboBoxSaatler.DataSource=SaatViewModel.
        }

        private void comboBoxSaatler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

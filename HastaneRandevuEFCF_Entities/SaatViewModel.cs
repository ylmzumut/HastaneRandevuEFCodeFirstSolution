using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuEFCF_Entities
{
    public class SaatViewModel
    {
        public int ID { get; set; }
        public string SaatDilimi { get; set; }

        public static List<SaatViewModel> SaatlerListesiniGetir()
        {
            List<SaatViewModel> liste = new List<SaatViewModel>()
            {
                (new SaatViewModel
            {
                ID=9,
                SaatDilimi="09:00"
            } ),
            (new SaatViewModel
            {
                ID = 10,
                SaatDilimi = "10:00"
            }),
            (new SaatViewModel
            {
                ID = 11,
                SaatDilimi = "11:00"
            }),
            (new SaatViewModel
            {
                ID = 13,
                SaatDilimi = "13:00"
            }),
            (new SaatViewModel
            {
                ID = 14,
                SaatDilimi = "14:00"
            }),
            (new SaatViewModel
            {
                ID = 15,
                SaatDilimi = "15:00"
            })
            };

            return liste;
        }
    }
}

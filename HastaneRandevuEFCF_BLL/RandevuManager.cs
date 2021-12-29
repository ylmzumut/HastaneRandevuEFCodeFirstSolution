using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneRandevuEFCF_DAL;
using HastaneRandevuEFCF_Entities;

namespace HastaneRandevuEFCF_BLL
{
    public class RandevuManager
    {
        //Global alan
        MyContext myDBContext = new MyContext();

        public List<RandevuBilgileri> DoktorunRandevulariniTariheGoreGetir(Doktor dr, DateTime trh)
        {
            try
            {
                List<RandevuBilgileri> rndList = new List<RandevuBilgileri>();

                rndList = myDBContext.RandevuBilgileri.Where(x => x.DoktorID == dr.DoktorID).ToList();
                //Burada foreach döngüsü kullanmadık çünkü foreach koleksiyonu bozamaz. Biz burada tarihi eşleşmeyen randevuları listemizden sileceğiz.
                for (int i = 0; i < rndList.Count; i++)
                {
                    if (rndList[i].RandevuTarihi.ToShortDateString() != trh.ToShortDateString())
                    {
                        rndList.Remove(rndList[i]);
                    }
                }

                return rndList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool HastaninSecilenTarihveSaatteRandevusuVarMi(Hasta hasta,DateTime trh)
        {
            try
            {
                bool sonuc = false;

                var liste = myDBContext.RandevuBilgileri.Where(x => x.HastaID == hasta.HastaID && x.RandevuTarihi==trh).ToList();

                sonuc = liste.Count > 0 ? true : false;
                return sonuc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool RandevuyuAl(RandevuBilgileri rnd)
        {
            try
            {
                myDBContext.RandevuBilgileri.Add(rnd);
                if (myDBContext.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

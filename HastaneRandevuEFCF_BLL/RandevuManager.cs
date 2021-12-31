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
                List<RandevuBilgileri> returnList = new List<RandevuBilgileri>();

                rndList = myDBContext.RandevuBilgileri.Where(x => x.DoktorID == dr.DoktorID).ToList();
                //1.yöntem ---> for
                //for (int i = 0; i < rndList.Count; i++)
                //{
                //    if (rndList[i].RandevuTarihi.ToShortDateString() == trh.ToShortDateString())
                //    {
                //        returnList.Add(rndList[i]);
                //    }
                //}

                //2.yöntem ---> foreach
                foreach (RandevuBilgileri item in rndList)
                {
                    if (item.RandevuTarihi.ToShortDateString() == trh.ToShortDateString())
                    {
                        returnList.Add(item);
                    }
                }

                return returnList;
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

        public RandevuBilgileriViewModel RandevuyuViewModeleAktar(RandevuBilgileri rnd)
        {
            try
            {
                RandevuBilgileriViewModel rndView = new RandevuBilgileriViewModel()
                {
                    RandevuID = rnd.ID,
                    DoktorID = rnd.DoktorID,
                    HastaID = rnd.HastaID,
                    RandevuTarihi = rnd.RandevuTarihi
                };
                Hasta hst = myDBContext.Hastalar.FirstOrDefault(x => x.HastaID == rnd.HastaID);
                rndView.HastaAdSoyad = hst?.HastaAdi + " " + hst?.HastaSoyadi;
                Doktor dr = myDBContext.Doktorlar.FirstOrDefault(x => x.DoktorID == rnd.DoktorID);
                rndView.DoktorAdSoyad = dr?.DoktorAdi + " " + dr?.DoktorSoyadi;
                //servis
                rndView.Servis = EnumManager.BransiTurkceStringOlarakVer(rnd.Doktor.Brans);
                return rndView;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

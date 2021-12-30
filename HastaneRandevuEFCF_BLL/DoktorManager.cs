using HastaneRandevuEFCF_DAL;
using HastaneRandevuEFCF_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuEFCF_BLL
{
    public class DoktorManager
    {
        
        //global alan
        MyContext myDBContext = new MyContext();

        public bool YeniDoktorEkle(Doktor yeniDr)
        {
            try
            {
                //1.yöntem
                myDBContext.Doktorlar.Add(yeniDr);
                //2.yöntem  --->  Bu yöntemi ilerleyen derslerde Repository design pattern konusunda yani mcv'de kullanacaağız.
                //myDBContext.Set<Doktor>().Add(yeniDr);

                myDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Doktor> TumAktifDoktorlariGetir()
        {
            try
            {
                //1.yöntem
                //List<Doktor> drList = new List<Doktor>();
                //drList=myDBContext.Doktorlar.ToList();
                //return drList;

                //2.yöntem
                return myDBContext.Doktorlar.Where(x=>x.AktifMi).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Doktor> BransaGoreDoktorlariGetir(Branslar brans)
        {
            try
            {
                return myDBContext.Doktorlar.Where(x => x.Brans == brans).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Doktor DoktoruIDyeGoreBul(int id)
        {
            try
            {
                Doktor dr = myDBContext.Doktorlar.FirstOrDefault(x => x.DoktorID == id);
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

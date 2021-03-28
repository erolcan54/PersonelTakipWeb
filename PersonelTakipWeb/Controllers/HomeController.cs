using PersonelTakipWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelTakipWeb.Controllers
{
    public class HomeController : Controller
    {
        PersonelBaglanti baglanti = new PersonelBaglanti();

        public ActionResult Index()
        {
            List<Personeller> personelListe = PersonelListele();
            return View(personelListe);
        }

        public List<Personeller> PersonelListele()
        {
            List<Personeller> personelListe = baglanti.Personeller.ToList();
            return personelListe;
        }

        public ActionResult PersonelGetir()
        {
            Personeller personel = baglanti.Personeller.Where(p=>p.PersonelID==1).FirstOrDefault();
            return View(personel);
        }

        public ActionResult PersonelEkleSayfasi()
        {
            return View();
        }

        public ActionResult PersonelEkle(Personeller personel)
        {
            
            baglanti.Personeller.Add(personel);
            baglanti.SaveChanges();

            List<Personeller> personelListe = PersonelListele();
            return View("Index",personelListe);
        }
    }
}

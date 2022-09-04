using Microsoft.VisualStudio.TestTools.UnitTesting;
using P02AplikacjaZawodnicy;
using P05BibliotekaZawodnikVM;
using System;

namespace P03TestyAplikacjiZawodnicy
{
    [TestClass]
    public class TestDodawaniaZawodnika
    {
        [TestMethod]
        public void Scenariusz1()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            ZawodnikVM zvm = new ZawodnikVM()
            {
                Imie = "jan",
                Nazwisko = "kowalski",
                Kraj = "pol",
                Miasto = "warszawa",
                DataUr = DateTime.Now,
                Waga = 90,
                Wzrost = 190,
            };

            int ile = zr.WczytajZawodnikow("", "").Length;

            zr.DodajZawodnika(zvm);

            int oczekuemy = ile + 1;

            int aktulanie = zr.WczytajZawodnikow("", "").Length;

            Assert.AreEqual(oczekuemy, aktulanie);
        }

        public void Scenariusz2()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            ZawodnikVM zvm = new ZawodnikVM()
            {
                Imie = "jan",
                Nazwisko = "kowalski",
                //Kraj = "pol",
                //Miasto = "warszawa",
                //DataUr = DateTime.Now,
                //Waga = 90,
                //Wzrost = 190,
            };

            int ile = zr.WczytajZawodnikow("", "").Length;

            zr.DodajZawodnika(zvm);

            int oczekuemy = ile + 1;

            int aktulanie = zr.WczytajZawodnikow("", "").Length;

            Assert.AreEqual(oczekuemy, aktulanie);
        }
    }
}
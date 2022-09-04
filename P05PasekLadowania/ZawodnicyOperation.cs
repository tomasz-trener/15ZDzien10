using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05PasekLadowania
{
    internal class ZawodnicyOperation
    {
        private readonly ListBox lbDane;
        private readonly ProgressBar pbPasekPostepu;

        public ZawodnicyOperation(ListBox lbDane, ProgressBar pbPasekPostepu)
        {
            this.lbDane = lbDane;
            this.pbPasekPostepu = pbPasekPostepu;
        }

        public void WczytajWieluZawodnikow()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            int[] identyfikatory = zr.WczytajZawodnikow("", "").Select(x => x.Id_zawodnika).ToArray();

            pbPasekPostepu.Maximum = identyfikatory.Length;
            pbPasekPostepu.Value = 0;
            lbDane.Items.Clear();

            foreach (var id in identyfikatory)
            {
                var zawodnik = zr.WczytajZawodnika(id);
                pbPasekPostepu.Value++;
                lbDane.Items.Add("wczytano: " + zawodnik.Imie + " " + zawodnik.Nazwisko);
            }
        }
    }
}
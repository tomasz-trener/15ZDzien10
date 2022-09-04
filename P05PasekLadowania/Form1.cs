using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05PasekLadowania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStrat_Click(object sender, EventArgs e)
        {
            ZawodnicyOperation zo = new ZawodnicyOperation(lbDane, pbPasekPostepu);
            zo.WczytajWieluZawodnikow();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace P04AutentykacjaAplikacjiDesktopowej
{
    public partial class FrmLogowanie : Form
    {
        public FrmLogowanie()
        {
            InitializeComponent();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            string nazwa = txtLogin.Text;
            string haslo = txtHaslo.Text;

            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            var u = db.aspnet_Users.Where(x => x.LoweredUserName == nazwa.ToLower()).FirstOrDefault();

            if (u == null)
            {
                MessageBox.Show("Niepoprawne logowanie");
                return;
            }

            string nazwaUzytnikaZBazy = u.LoweredUserName;
            string hashHasla = u.aspnet_Membership.Password;

            string mojHash = EncodePassword(haslo, u.aspnet_Membership.PasswordSalt);

            if (mojHash == hashHasla)
            {
                Form1 fs = new Form1();
                fs.Show();
                this.Hide();
            }
        }

        private string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        private string EncodePassword(string pass, string salt)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(pass);
            byte[] src = Convert.FromBase64String(salt);
            byte[] dst = new byte[src.Length + bytes.Length];
            byte[] inArray = null;
            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
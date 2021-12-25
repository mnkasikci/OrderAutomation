using OrderAutomation.Global;
using System;
using System.Windows.Forms;

namespace OrderAutomation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(LoginGecerli(kullaniciAdi.Text,sifre.Text))
            {
                var x = GetKullaniciTipi(kullaniciAdi.Text);
                switch (x)
                {
                    case UserType.Admin:

                        break;
                    case UserType.Musteri:
                        this.Hide();
                        var avEkrani = new AlisVerisEkrani();
                        avEkrani.Closed += (s, args) => this.Close();
                        avEkrani.Show();
                        break;
                }
            }
        }

        private bool LoginGecerli(string userName,string password)
        {
            return true;
        }
        private UserType GetKullaniciTipi(string text)
        {
            return UserType.Musteri;
        }
    }
}

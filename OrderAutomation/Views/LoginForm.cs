using OrderAutomation.Global;
using OrderAutomation.Models;
using System;
using System.Windows.Forms;

namespace OrderAutomation.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = AttemptLogin(kullaniciAdi.Text, sifre.Text);
            if (user != null)
            {
                Customer customer = user as Customer;
                Admin admin = user as Admin;
                if (customer != null)
                {
                    Hide();
                    var avEkrani = new AlisVerisEkrani(customer);
                    avEkrani.Closed += (s, args) => this.Close();
                    avEkrani.Show();
                }
                else if(admin != null)
                {

                }
                else
                {
                    throw new TypeUnloadedException();
                }

            }
        }

        private User AttemptLogin(string userName, string password)
        {
            return new Customer()
            {
                Id = 2
            };
        }
        private UserType GetKullaniciTipi(string text)
        {
            return UserType.Customer;
        }
    }
}

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
                if (user is Customer customer)
                {
                    Hide();
                    var avEkrani = new AlisVerisEkrani(customer);
                    avEkrani.Closed += (s, args) => this.Close();
                    avEkrani.Show();
                }
                else if (user is Admin admin)
                {
                    Hide();
                    var adminEkrani = new AdminPanel(admin);
                    adminEkrani.Closed += (s, args) => this.Close();
                    adminEkrani.Show();
                }
                else
                {
                    throw new TypeUnloadedException();
                }

            }
        }

        private static User AttemptLogin(string userName, string password)
        {
            var user = DB.DBHelper.AttemptLogin(userName, password);
            return user;
            
        }
    }
}

using OrderAutomation.Models;
using System;
using System.Windows.Forms;

namespace OrderAutomation.Views
{
    public partial class CekOdeme : Form
    {
        private readonly Order _order;

        public CekOdeme(Models.Order order)
        {
            InitializeComponent();
            _order = order;
            button1.Enabled = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Check check = new(_order, nameTextBox.Text, bankIdTextBox.Text);
            check.ProcessPayment();
            MessageBox.Show("Çek ile Ödeme Gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            var avEkrani= new AlisVerisEkrani(_order.Customer);
            avEkrani.Closed += (s, args) => this.Close();
            avEkrani.Show();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            _nameIsFull = !String.IsNullOrWhiteSpace(nameTextBox.Text);
            CheckEnabled();
        }

        private bool _nameIsFull, _bankIdIsFull;

        private void bankIdTextBox_TextChanged(object sender, EventArgs e)
        {
            _bankIdIsFull = !String.IsNullOrWhiteSpace(nameTextBox.Text);
            CheckEnabled();
        }

        private void CheckEnabled()
        {
            button1.Enabled = _nameIsFull && _bankIdIsFull;
        }
    }
}

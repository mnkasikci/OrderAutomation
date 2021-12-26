using OrderAutomation.Models;
using System;
using System.Windows.Forms;

namespace OrderAutomation.Views
{
    public partial class KrediKarti : Form
    {
        public KrediKarti(Order order)
        {
            
            InitializeComponent();
            button1.Enabled = false;
            HataIkon.Hide();
            formataUygunDegilText.Hide();
            _order = order;
        }

        bool AdSoyadGecerli = false;
        bool KartNoGecerli = false;
        bool CVCGecerli = false;
        bool SKTAYGecerli = false;
        bool SKTYilGecerli = false;
        private readonly Order _order;

        private void kartNoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (kartNoTextBox.Text.Length == 16)
            {
                HataIkon.Hide();
                formataUygunDegilText.Hide();
            }
        }
        private void kartNoTextBox_Leave(object sender, EventArgs e)
        {
            if (kartNoTextBox.Text.Length != 16)
            {
                HataIkon.Show();
                formataUygunDegilText.Show();
                KartNoGecerli = false;
                UpdateButtonEnabled();
            }
            else
            {
                formataUygunDegilText.Hide();
                HataIkon.Hide();
                KartNoGecerli = true;
                UpdateButtonEnabled();
            }

        }


        private void kartNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text.Length >= 3)
            {
                textBox3.Text = textBox3.Text.Substring(0, 3);
                CVCGecerli = true;
            }
            else
                CVCGecerli = false;
            UpdateButtonEnabled();
        }

        void UpdateButtonEnabled()
        {
            button1.Enabled = AdSoyadGecerli && KartNoGecerli && CVCGecerli && SKTAYGecerli && SKTYilGecerli;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var expDateString = comboBox1.SelectedValue.ToString() + comboBox2.SelectedValue.ToString();
            Credit credit = new Credit(_order, kartNoTextBox.ToString(), adSoyad.ToString(), expDateString);
            credit.ProcessPayment();
            MessageBox.Show("Kredi Kartı ile Ödeme Gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            var avEkrani = new AlisVerisEkrani(_order.Customer);
            avEkrani.Show();
            avEkrani.FormClosed += (s, args) => this.Close();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            AdSoyadGecerli = adSoyad.Text != "";
            UpdateButtonEnabled();
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            SKTAYGecerli = true;
            UpdateButtonEnabled();
        }

        private void comboBox2_DropDownClosed(object sender, EventArgs e)
        {
            SKTYilGecerli = true;
            UpdateButtonEnabled();
        }
    }
}

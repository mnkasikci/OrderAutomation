using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAutomation
{
    public partial class OdemeEkrani : Form
    {
        public OdemeEkrani()
        {
            InitializeComponent();
        }
        public OdemeEkrani(decimal toplamFiyat, decimal vergisizToplamFiyat) 
        {
            InitializeComponent();
            toplamBedel.Text = toplamFiyat.ToString();
            VergisizToplamBedel.Text = vergisizToplamFiyat.ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OdemeEkrani_Load(object sender, EventArgs e)
        {
            
        }

        private void VergisizToplamBedelEtiketi_Click(object sender, EventArgs e)
        {

        }

        private void nakitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nakit Ödeme Gerçekleşti","Başlık",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

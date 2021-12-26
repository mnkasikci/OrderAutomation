using System.Threading.Tasks;
using System.Windows.Forms;
using OrderAutomation.DB;
using OrderAutomation.FormDbHelper;
using OrderAutomation.Models;

namespace OrderAutomation.Views
{
    public partial class AdminPanel : Form
    {
        private readonly Admin _admin;

        public AdminPanel(Admin admin)
        {
            InitializeComponent();
            //Task orders = Task.Run(() => ordersGrid.LoadOrders());
            //Task payments = Task.Run(() => paymentsGrid.LoadPayments());
            //Task items= Task.Run(() => itemsGrid.LoadItems());
            ordersGrid.LoadOrders();
            itemsGrid.LoadItems();
            paymentsGrid.LoadPayments();
            _admin = admin;

        }

        private void addItem_Click(object sender, System.EventArgs e)
        {
            var newWindow = new AddItemForm(itemsGrid);
            newWindow.Show();
        }

        private void deleteItem_Click(object sender, System.EventArgs e)
        {
            var itemDeleteId = int.Parse(itemsGrid.SelectedRows[0].Cells[0].Value.ToString());
            DBHelper.DeleteItem(itemDeleteId);
            itemsGrid.LoadItems();
        }
    }
}

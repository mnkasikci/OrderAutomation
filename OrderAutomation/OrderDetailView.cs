using OrderAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAutomation
{
   public class OrderDetailView : OrderDetail
    {
        internal void AddItemView(int urunAdet, Item itemView)
        {
            if (!Items.Exists(x => x.Id == itemView.Id))
            {
                itemView.Quantity = urunAdet;
                Items.Add(itemView);
            }
            else
            {
                var itm = Items.Find(i => i.Id == itemView.Id);
                itm.Quantity += urunAdet;
            }
        }

        internal void ReGenerate(ListBox listBox1)
        {
            listBox1.Items.Clear();
            foreach(var item in Items)
            {
                listBox1.Items.Add($"{item.Quantity} * {item.Name}");
            }
        }

        internal void ClearItems()
        {
            Items = new();
        }
    }
}

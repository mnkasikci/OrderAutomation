using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.ViewModels
{
	public class PaymentView
	{
		public DateTime Date { get; set; }
		public string UserName { get; set; }
		public string Address { get; set; }
		public decimal? TotalAmount { get; set; }
		public string PaymentType { get; set; }
		public string CardNumber { get; set; }
		public string NameOnCard { get; set; }
		public string BankId { get; set; }
		public decimal? CashTendered { get; set; }
		public decimal? Change { get; set; }
		
	}
}

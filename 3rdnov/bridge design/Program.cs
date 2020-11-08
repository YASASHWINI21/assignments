using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgePattern;


namespace BridgePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Payment order = new CardPayment();
			order._IPaymentSystem = new AxisBankPS();
			order.MakePayment();
			order._IPaymentSystem = new AxisBankPS.IDBIBankPS();
			order.MakePayment();
			order = new NetBankingPayment();
			order._IPaymentSystem = new AxisBankPS();
			order.MakePayment();

			Console.ReadKey();
		}
	}
}
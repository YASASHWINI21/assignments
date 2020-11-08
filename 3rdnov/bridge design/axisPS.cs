using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgePattern;


namespace BridgePattern
{
	public class AxisBankPS : IPaymentSystem
	{
		public void ProcessPayment(string paymentSystem)
		{
			Console.WriteLine("Using AxisBank gateway for" + paymentSystem);
			Console.ReadLine();
		}
		public class IDBIBankPS : IPaymentSystem
		{
			public void ProcessPayment(string paymentSystem)
			{
				Console.WriteLine("Using IDBIBank gateway for" + paymentSystem);
				Console.ReadLine();
			}
			

		}
	}
}

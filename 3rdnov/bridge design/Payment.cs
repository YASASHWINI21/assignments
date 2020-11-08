using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
	public abstract class Payment
	{
		public IPaymentSystem _IPaymentSystem;
		public abstract void MakePayment();

	}
	public class CardPayment : Payment
	{
		public override void MakePayment()
		{
			_IPaymentSystem.ProcessPayment(" Card Payment");
		}

	}
	public class NetBankingPayment : Payment
	{
		public override void MakePayment()
		{
			_IPaymentSystem.ProcessPayment("NetBankingPayment");
		}

	}
}

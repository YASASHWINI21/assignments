using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
	abstract class Creator
	{
		// Note that the Creator may also provide some default implementation of
		// the factory method.
		public abstract IProduct FactoryMethod();

		
		public string SomeOperation()
		{
			// Call the factory method to create a Product object.
			var product = FactoryMethod();
			// Now, use the product.
			var result = "Creator: The same creator's code has just worked with "
				+ product.Operation();

			return result;
		}
	}

	// Concrete Creators override the factory method in order to change the
	// resulting product's type.
	class ConcreteCreator1 : Creator
	{
		
		public override IProduct FactoryMethod()
		{
			return new ConcreteProduct1();
		}
	}

	class ConcreteCreator2 : Creator
	{
		public override IProduct FactoryMethod()
		{
			return new ConcreteProduct2();
		}
	}

	// The Product interface declares the operations that all concrete products
	// must implement.
	public interface IProduct
	{
		string Operation();
	}

	// Concrete Products provide various implementations of the Product
	// interface.
	class ConcreteProduct1 : IProduct
	{
		public string Operation()
		{
			return "{Result of ConcreteProduct1}";
		}
	}

	class ConcreteProduct2 : IProduct
	{
		public string Operation()
		{
			return "{Result of ConcreteProduct2}";
		}
	}

	class Client
	{
		public void Main()
		{
			Console.WriteLine("App: Launched with the ConcreteCreator1.");
			ClientCode(new ConcreteCreator1());

			Console.WriteLine("");

			Console.WriteLine("App: Launched with the ConcreteCreator2.");
			ClientCode(new ConcreteCreator2());
		}

		
		public void ClientCode(Creator creator)
		{
			// ...
			Console.WriteLine("Client: I'm not aware of the creator's class," +
				"but it still works.\n" + creator.SomeOperation());
			Console.ReadLine();
			
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			new Client().Main();
		}
	}
}
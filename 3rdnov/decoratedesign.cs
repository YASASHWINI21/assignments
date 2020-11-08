using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public abstract class Component
	{
		public abstract string Operation();
	}

	// Concrete Components provide default implementations of the operations.
	// There might be several variations of these classes.
	class ConcreteComponent : Component
	{
		public override string Operation()
		{
			return "ConcreteComponent";
		}
	}

	abstract class Decorator : Component
	{
		protected Component _component;

		public Decorator(Component component)
		{
			this._component = component;
		}

		public void SetComponent(Component component)
		{
			this._component = component;
		}

		// The Decorator delegates all work to the wrapped component.
		public override string Operation()
		{
			if (this._component != null)
			{
				return this._component.Operation();
			}
			else
			{
				return string.Empty;
			}
		}
	}

	// Concrete Decorators call the wrapped object and alter its result in some
	// way.
	class ConcreteDecoratorA : Decorator
	{
		public ConcreteDecoratorA(Component comp) : base(comp)
		{
		}

		// Decorators may call parent implementation of the operation, instead
		// of calling the wrapped object directly. This approach simplifies
		// extension of decorator classes.
		public override string Operation()
		{
			return $"ConcreteDecoratorA({base.Operation()})";
		}
	}

	// Decorators can execute their behavior either before or after the call to
	// a wrapped object.
	class ConcreteDecoratorB : Decorator
	{
		public ConcreteDecoratorB(Component comp) : base(comp)
		{
		}

		public override string Operation()
		{
			return $"ConcreteDecoratorB({base.Operation()})";
		}
	}

	public class Client
	{
		// The client code works with all objects using the Component interface.
		// This way it can stay independent of the concrete classes of
		// components it works with.
		public void ClientCode(Component component)
		{
			Console.WriteLine("RESULT: " + component.Operation());
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Client client = new Client();

			var simple = new ConcreteComponent();
			Console.WriteLine("Client: I get a simple component:");
			client.ClientCode(simple);
			Console.WriteLine();

			// ...as well as decorated ones.
			//
			// Note how decorators can wrap not only simple components but the
			// other decorators as well.
			ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
			ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
			Console.WriteLine("Client: Now I've got a decorated component:");
			client.ClientCode(decorator2);

			Console.ReadLine();
		}
	}
}
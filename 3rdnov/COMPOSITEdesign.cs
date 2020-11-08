using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignpattern
{
	abstract class Component
	{
		public Component() { }

		// The base Component may implement some default behavior or leave it to
		// concrete classes (by declaring the method containing the behavior as
		// "abstract").
		public abstract string Operation();

		public virtual void Add(Component component)
		{
			throw new NotImplementedException();
		}

		public virtual void Remove(Component component)
		{
			throw new NotImplementedException();
		}

		
		public virtual bool IsComposite()
		{
			return true;
		}
	}

	
	class Leaf : Component
	{
		public override string Operation()
		{
			return "Leaf";
		}

		public override bool IsComposite()
		{
			return false;
		}
	}

	// The Composite class represents the complex components that may have children. 
	class Composite : Component
	{
		protected List<Component> _children = new List<Component>();

		public override void Add(Component component)
		{
			this._children.Add(component);
		}

		public override void Remove(Component component)
		{
			this._children.Remove(component);
		}

		
		public override string Operation()
		{
			int i = 0;
			string result = "Branch(";

			foreach (Component component in this._children)
			{
				result += component.Operation();
				if (i != this._children.Count - 1)
				{
					result += "+";
				}
				i++;
			}

			return result + ")";
		}
	}

	class Client
	{
		// The client code works with all of the components via the base
		// interface.
		public void ClientCode(Component leaf)
		{
			Console.WriteLine($"RESULT: {leaf.Operation()}\n");
		}

		
		public void ClientCode2(Component component1, Component component2)
		{
			if (component1.IsComposite())
			{
				component1.Add(component2);
			}

			Console.WriteLine($"RESULT: {component1.Operation()}");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Client client = new Client();

			// This way the client code can support the simple leaf
			// components...
			Leaf leaf = new Leaf();
			Console.WriteLine("Client: I get a simple component:");
			client.ClientCode(leaf);

			// ...as well as the complex composites.
			Composite tree = new Composite();
			Composite branch1 = new Composite();
			branch1.Add(new Leaf());
			branch1.Add(new Leaf());
			Composite branch2 = new Composite();
			branch2.Add(new Leaf());
			tree.Add(branch1);
			tree.Add(branch2);
			Console.WriteLine("Client: Now I've got a composite tree:");
			client.ClientCode(tree);

			Console.WriteLine("Client: I don't need to check the components classes even when managing the tree:\n");
			client.ClientCode2(tree, leaf);

			Console.ReadLine();
}
}
}

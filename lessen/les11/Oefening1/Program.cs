using System;
using System.Collections.Generic;

namespace Oefening1.DesignPatterns.Builder.Conceptual
{
	public interface IBuilder
	{
		void buildVoorpagina();

		void buildBinnenland();

		void buildBuitenland();
		void buildReclame();
	}

	// The Concrete Builder classes follow the Builder interface and provide
	// specific implementations of the building steps. Your program may have
	// several variations of Builders, implemented differently.
	public class DeMorgen : IBuilder
	{
		private krant _krant = new krant();

		// A fresh builder instance should contain a blank krant object, which
		// is used in further assembly.
		public DeMorgen()
		{
			this.Reset();
		}

		public void Reset()
		{
			this._krant = new krant();
		}

		// All krantion steps work with the same krant instance.
		public void buildVoorpagina()
		{
			this._krant.Add("Logo");
			this._krant.Add("Foto");
			this._krant.Add("Titel");
			this._krant.Add("Sectie");
			this._krant.Add("Reclame");
		}

		public void buildBinnenland()
		{
			this._krant.Add("Foto");
			this._krant.Add("Titel");
			this._krant.Add("Sectie");
		}

		public void buildBuitenland()
		{
			this._krant.Add("Foto");
			this._krant.Add("Titel");
			this._krant.Add("Sectie");
		}
		public void buildReclame()
		{
			this._krant.Add("Foto");
		}

		// Concrete Builders are supposed to provide their own methods for
		// retrieving results. That's because various types of builders may
		// create entirely different krants that don't follow the same
		// interface. Therefore, such methods cannot be declared in the base
		// Builder interface (at least in a statically typed programming
		// language).
		//
		// Usually, after returning the end result to the client, a builder
		// instance is expected to be ready to start producing another krant.
		// That's why it's a usual practice to call the reset method at the end
		// of the `Getkrant` method body. However, this behavior is not
		// mandatory, and you can make your builders wait for an explicit reset
		// call from the client code before disposing of the previous result.
		public krant Getkrant()
		{
			krant result = this._krant;

			this.Reset();

			return result;
		}
	}

	public class DeTijd : IBuilder
	{
		private krant _krant = new krant();

		// A fresh builder instance should contain a blank krant object, which
		// is used in further assembly.
		public DeTijd()
		{
			this.Reset();
		}

		public void Reset()
		{
			this._krant = new krant();
		}

		// All krantion steps work with the same krant instance.
		public void buildVoorpagina()
		{
			this._krant.Add("Logo");
			this._krant.Add("Titel");
			this._krant.Add("Foto");
			this._krant.Add("Sectie");
			this._krant.Add("Reclame");
		}

		public void buildBinnenland()
		{
			this._krant.Add("Titel");
			this._krant.Add("Foto");
			this._krant.Add("Sectie");
		}

		public void buildBuitenland()
		{
			this._krant.Add("Titel");
			this._krant.Add("Foto");
			this._krant.Add("Sectie");
		}
		public void buildReclame()
		{
			this._krant.Add("Foto");
		}

		// Concrete Builders are supposed to provide their own methods for
		// retrieving results. That's because various types of builders may
		// create entirely different krants that don't follow the same
		// interface. Therefore, such methods cannot be declared in the base
		// Builder interface (at least in a statically typed programming
		// language).
		//
		// Usually, after returning the end result to the client, a builder
		// instance is expected to be ready to start producing another krant.
		// That's why it's a usual practice to call the reset method at the end
		// of the `Getkrant` method body. However, this behavior is not
		// mandatory, and you can make your builders wait for an explicit reset
		// call from the client code before disposing of the previous result.
		public krant Getkrant()
		{
			krant result = this._krant;

			this.Reset();

			return result;
		}
	}

	// It makes sense to use the Builder pattern only when your krants are
	// quite complex and require extensive configuration.
	//
	// Unlike in other creational patterns, different concrete builders can
	// produce unrelated krants. In other words, results of various builders
	// may not always follow the same interface.
	public class krant
	{
		private List<object> _parts = new List<object>();

		public void Add(string part)
		{
			this._parts.Add(part);
		}

		public string ListParts()
		{
			string str = string.Empty;

			for (int i = 0; i < this._parts.Count; i++)
			{
				str += this._parts[i] + ", ";
			}

			str = str.Remove(str.Length - 2); // removing last ",c"

			return "krant parts: " + str + "\n";
		}
	}

	// The Director is only responsible for executing the building steps in a
	// particular sequence. It is helpful when producing krants according to a
	// specific order or configuration. Strictly speaking, the Director class is
	// optional, since the client can control builders directly.
	public class Director
	{
		private IBuilder _builder;

		public IBuilder Builder
		{
			set { _builder = value; }
		}

		// The Director can construct several krant variations using the same
		// building steps.
		public void buildMinimalViablekrant()
		{
			this._builder.buildVoorpagina();
		}

		public void buildFullFeaturedkrant()
		{
			this._builder.buildVoorpagina();
			this._builder.buildBinnenland();
			this._builder.buildBuitenland();
			this._builder.buildReclame();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			// The client code creates a builder object, passes it to the
			// director and then initiates the construction process. The end
			// result is retrieved from the builder object.
			var director = new Director();
			var builder = new DeMorgen();
			director.Builder = builder;

			Console.WriteLine("Standard basic krant:");
			director.buildMinimalViablekrant();
			Console.WriteLine(builder.Getkrant().ListParts());

			Console.WriteLine("Standard full featured krant:");
			director.buildFullFeaturedkrant();
			Console.WriteLine(builder.Getkrant().ListParts());

			// Remember, the Builder pattern can be used without a Director
			// class.
			Console.WriteLine("Custom krant:");
			builder.buildVoorpagina();
			builder.buildBuitenland();
			Console.Write(builder.Getkrant().ListParts());


			var director2 = new Director();
			var builder2 = new DeTijd();
			director2.Builder = builder2;

			Console.WriteLine("Standard basic krant:");
			director2.buildMinimalViablekrant();
			Console.WriteLine(builder2.Getkrant().ListParts());

			Console.WriteLine("Standard full featured krant:");
			director2.buildFullFeaturedkrant();
			Console.WriteLine(builder2.Getkrant().ListParts());

			// Remember, the Builder pattern can be used without a Director
			// class.
			Console.WriteLine("Custom krant:");
			builder.buildVoorpagina();
			builder.buildBuitenland();
			Console.Write(builder2.Getkrant().ListParts());
		}
	}
}

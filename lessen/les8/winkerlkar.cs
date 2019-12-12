using System;

namespace les8
{
	public abstract class Winkelkar
	{
		public abstract void Ontgrendelen();
		public abstract void Rijden();
	}
	public class PlasticKar : Winkelkar
	{
		public PlasticKar()
		{
		}
		public override void Ontgrendelen()
		{
		}
		public override void Rijden()
		{
		}
	}


	public class GroteKar : Winkelkar
	{
		public override void Ontgrendelen()
		{
			throw new NotImplementedException();
		}

		public override void Rijden()
		{
			throw new NotImplementedException();
		}
	}
}
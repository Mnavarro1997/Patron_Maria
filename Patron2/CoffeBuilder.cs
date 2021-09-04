using System;
using System.Collections.Generic;
using System.Text;

namespace Patron2
{
    class CoffeBuilder
    {

		public string _Type;
		public List<Milk> _ListMilk;
		public List<Sugar> _ListSugar;


		public CoffeBuilder()
		{
			_ListMilk = new List<Milk>();
			_ListSugar = new List<Sugar>();
		}

		public CoffeBuilder SetBlackCoffee()
		{
			_Type = "Black";
			return this;
		}
		public CoffeBuilder SetCubanoCoffee()
		{
			_Type = "Cubano";
			_ListSugar.Add(new Sugar("Brown"));
			return this;
		}
		public CoffeBuilder SetAntoccinoCoffee()
		{
			_Type = "Americano";
			_ListMilk.Add(new Milk(0.0));
			return this;
		}

		public CoffeBuilder WithMilk(double fat)
		{
			_ListMilk.Add(new Milk(fat));
			return this;
		}
		public CoffeBuilder WithSugar(string sort)
		{
			_ListSugar.Add(new Sugar(sort));
			return this;
		}

		public Coffee Build() { return new Coffee(_Type, _ListMilk, _ListSugar); }
	};
}


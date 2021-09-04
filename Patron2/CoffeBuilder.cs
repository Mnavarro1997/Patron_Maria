using System;
using System.Collections.Generic;
using System.Text;

namespace Patron2
{
    class CoffeBuilder
    {

		public string _sort;
		public List<Milk> _listMilk;
		public List<Sugar> _listSugar;


		public CoffeBuilder()
		{
			_listMilk = new List<Milk>();
			_listSugar = new List<Sugar>();
		}

		public CoffeBuilder SetBlackCoffee()
		{
			_sort = "Black";
			return this;
		}
		public CoffeBuilder SetCubanoCoffee()
		{
			_sort = "Cubano";
			_listSugar.Add(new Sugar("Brown"));
			return this;
		}
		public CoffeBuilder SetAntoccinoCoffee()
		{
			_sort = "Americano";
			_listMilk.Add(new Milk(0.0));
			return this;
		}

		public CoffeBuilder WithMilk(double fat)
		{
			_listMilk.Add(new Milk(fat));
			return this;
		}
		public CoffeBuilder WithSugar(string sort)
		{
			_listSugar.Add(new Sugar(sort));
			return this;
		}

		public Coffee Build() { return new Coffee(_sort, _listMilk, _listSugar); }
	};
}


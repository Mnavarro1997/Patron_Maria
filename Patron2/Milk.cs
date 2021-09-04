namespace Patron2
{
    public class Milk
    {

		public readonly double Fat;

		public Milk(double fat)
		{
			Fat = fat;
		}
		public override string ToString()
		{
			return $"Milk: {Fat}.";
		}
	}
}
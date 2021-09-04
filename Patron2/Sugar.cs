namespace Patron2
{
    public class Sugar
    {

		public readonly string Sort;

		public Sugar(string sort)
		{
			Sort = sort;
		}
		public override string ToString()
		{
			return $"Sugar: {Sort}.";
		}
	}
}
namespace SimpleFinance.Domain.Common.Models.Base
{
	public abstract class DomainModel
	{
		private protected int _id { get; init; }

		internal DomainModel(int id)
		{
			_id = id;
		}
	}
}
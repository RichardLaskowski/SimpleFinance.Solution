namespace SimpleFinance.Domain.Common.Models.Base
{
	public class DomainModel
	{
		protected int Id { get; set; }

		public DomainModel(int id)
		{
			Id = id;
		}
	}
}
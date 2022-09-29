namespace SimpleFinance.Domain.Common.Models.Base
{
	public abstract class Category : DomainModel
	{
		private protected int CategoryId => _id;
		protected internal string Name { get; private set; }
		protected internal string Description { get; private set; }
		protected Category(int categoryId, string name, string description) : base(categoryId)
		{
			Name = name;
			Description = description;
		}
	}
}
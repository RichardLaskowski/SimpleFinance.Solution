namespace SimpleFinance.Domain.Common.Models.Base
{
	public class Owner : Person
	{
		public int OwnerId => PersonId;

		public Owner(
			int ownerId,
			string firstName,
			string lastName) : base(
				ownerId,
				firstName,
				lastName)
		{
			GuardOwner();
		}

		private protected void GuardOwner()
		{

		}
	}
}
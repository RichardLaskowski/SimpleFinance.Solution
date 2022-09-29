namespace SimpleFinance.Domain.Common.Models.Base
{
	public abstract class Person : DomainModel
	{
		private protected int PersonId { get => _id; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get => $"{FirstName} {LastName}"; }

		public Person(
			int personId,
			string firstName,
			string lastName) : base(personId)
		{
			FirstName = firstName;
			LastName = lastName;
		}
	}
}
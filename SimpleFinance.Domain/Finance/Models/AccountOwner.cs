using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Finance.Models
{
	public class AccountOwner : Owner
	{
		public int AccountOwnerId => OwnerId;

		public AccountOwner(
			int accountOwnerId,
			string firstName,
			string lastName) : base(
				accountOwnerId,
				firstName,
				lastName)
		{
		}
	}
}
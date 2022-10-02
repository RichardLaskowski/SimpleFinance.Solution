using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Finance.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountOwner : Owner
    {
        /// <summary>
        /// 
        /// </summary>
        public int AccountOwnerId => OwnerId;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountOwnerId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
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
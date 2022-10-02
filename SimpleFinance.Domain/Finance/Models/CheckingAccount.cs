using System.Collections.Generic;
using System.Collections.ObjectModel;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Finance.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckingAccount : Account
    {
        /// <summary>
        /// 
        /// </summary>
        public int CheckingAccountId => AccountId;

        /// <summary>
        /// 
        /// </summary>
        public string CheckingAccountNumber => AccountNumber;

        /// <summary>
        /// 
        /// </summary>
        public string AccountName => Name;

        /// <summary>
        /// 
        /// </summary>
        public string AccountDescription => Description;

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public ReadOnlyCollection<Owner> AccountOwners { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="checkingAccountId"></param>
        /// <param name="checkingAccountNumber"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="owners"></param>
        /// <returns></returns>
        public CheckingAccount(int checkingAccountId,
                        string checkingAccountNumber,
                        string name,
                        string description,
                        List<Owner> owners) : base(
                            checkingAccountId,
                            checkingAccountNumber,
                            name,
                            description,
                            owners)
        {
            AccountOwners = Owners;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Finance.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class SavingsAccount : Account
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public int SavingsAccountId { get => AccountId; }

        /// <summary>
        /// 
        /// </summary>
        public string SavingsAccountNumber => AccountNumber;

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
        /// <param name="savingsAccountId"></param>
        /// <param name="savingsAccountNumber"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="owners"></param>
        /// <returns></returns>
        public SavingsAccount(
            int savingsAccountId,
            string savingsAccountNumber,
            string name,
            string description,
            List<Owner> owners) : base(
                savingsAccountId,
                savingsAccountNumber,
                name,
                description,
                owners)
        {
            AccountOwners = Owners;
        }
    }
}
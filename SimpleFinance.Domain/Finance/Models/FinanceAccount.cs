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
    public class FinanceAccount : Account
    {
        /// <summary>
        /// 
        /// </summary>
        public int FinanceAccountId => AccountId;

        /// <summary>
        /// 
        /// </summary>
        public string FinanceAccountNumber => AccountNumber;

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
        /// <param name="financeAccountId"></param>
        /// <param name="financeAccountNumber"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="owners"></param>
        /// <returns></returns>
        public FinanceAccount(int financeAccountId,
                        string financeAccountNumber,
                        string name,
                        string description,
                        List<Owner> owners) : base(
                            financeAccountId,
                            financeAccountNumber,
                            name,
                            description,
                            owners)
        {
            AccountOwners = Owners;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain;

/// <summary>
/// 
/// </summary>
public class CreditCardAccount : Account
{
    /// <summary>
    /// 
    /// </summary>
    public int CreditCardAccountId => AccountId;

    /// <summary>
    /// 
    /// </summary>
    public string CreditCardNumber => AccountNumber;

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
    public decimal Balance { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal Limit { get; private set; }

    /// <summary>
    ///
    /// </summary>
    /// <value></value>
    public ReadOnlyCollection<Owner> AccountOwner { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="creditCardAccountId"></param>
    /// <param name="creditCardNumber"></param>
    /// <param name="balance"></param>
    /// <param name="limit"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="owners"></param>
    /// <returns></returns>
    public CreditCardAccount(
        int creditCardAccountId,
        string creditCardNumber,
        decimal balance,
        decimal limit,
        string name,
        string description,
        List<Owner> owners) : base(
            creditCardAccountId,
            creditCardNumber,
            name,
            description,
            owners)
    {
        AccountOwner = Owners;
        Balance = balance;
        Limit = limit;
    }

}
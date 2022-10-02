using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Common.Models;

/// <summary>
/// 
/// </summary>
public class Owner : Person
{
    /// <summary>
    /// 
    /// </summary>
    public int OwnerId => PersonId;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ownerId"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <returns></returns>
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
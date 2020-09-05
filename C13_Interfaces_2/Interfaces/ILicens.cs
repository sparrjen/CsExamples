using C13_Interfaces_2.Interfaces;

namespace C13_Interfaces_2.Models
{
    interface ILicens : IShoppingItem
    {
        int NumberOfLicenses { get; set; }
    }
}
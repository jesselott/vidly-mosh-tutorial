using System.ComponentModel;

namespace Vidly.Models
{
    public enum MembershipTypeNameEnum
    {
        [Description("Pay as You Go")]
        Pay_As_You_Go = 1,
        Weekly = 2,
        Monthly = 3,
        Annually = 4
    };
}
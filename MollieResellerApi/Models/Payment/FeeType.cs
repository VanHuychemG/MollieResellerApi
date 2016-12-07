using System.ComponentModel;

namespace MollieResellerApi.Models.Payment
{
    public enum FeeType
    {
        [Description("fixed")]
        Fixed,
        [Description("percentage")]
        Percentage
    }
}

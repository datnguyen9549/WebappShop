using Web.Data.Enums;

namespace Web.Data.Interfaces
{
    interface ISwitchable
    {
        Status status { get; set; }
    }
}

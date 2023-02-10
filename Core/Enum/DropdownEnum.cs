using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Enum
{
    public enum DropdownEnum
    {
        [Description("Gender")]
        Gender = 1,
        [Description("Country")]
        Country,


    }

    public enum JobTypeEnum
    {
        [Description("For Remote")]
        Remote = 1,
        [Description("For Onsite")]
        Onsite,
    }
    public enum Status
    {
        [Description("For Pending Payment")]
        Pending = 1,
        [Description("For Paid Payment")]
        Paid,
        [Description("For Delivered Payment")]
        Delivered,
        [Description("For Refund Payment")]
        Refund,
    }
}

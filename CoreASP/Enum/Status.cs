using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CoreASP.Enum
{
    public enum Status
    {
        [EnumMember(Value = "Awaiting Approval")]
        AwaitingApproval,
        Rejected,
        Accepted,
    }
}

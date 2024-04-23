using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CrmsalesArmactivityTypeMapping
{
    public long ActivityTypeMappingId { get; set; }

    public string? CrmactivityType { get; set; }

    public long? SalesArmactivityTypeId { get; set; }

    public bool? IsDefault { get; set; }

    public virtual ActivityType? SalesArmactivityType { get; set; }
}

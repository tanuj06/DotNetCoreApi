using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CrmsalesArmactivityStageMapping
{
    public long ActivityStageMappingId { get; set; }

    public string? CrmactivityStage { get; set; }

    public long? SalesArmactivityStageId { get; set; }

    public bool? IsDefault { get; set; }

    public virtual ActivityStage? SalesArmactivityStage { get; set; }
}

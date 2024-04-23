using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealStageAccessRightsGroupMapping
{
    public long AccessRightGroupMappingId { get; set; }

    public long DealStageId { get; set; }

    public long WorkflowGroupId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime ServerDateTime { get; set; }

    public virtual DealStage DealStage { get; set; } = null!;

    public virtual UserGroup WorkflowGroup { get; set; } = null!;
}

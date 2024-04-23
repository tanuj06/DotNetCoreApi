using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealWorkFlowUserGroupHistory
{
    public long GroupHistoryId { get; set; }

    public long DealId { get; set; }

    public long WorkFlowUserGroupId { get; set; }

    public long DealStageId { get; set; }

    public string? DealOrderNo { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public virtual Deal Deal { get; set; } = null!;

    public virtual DealStage DealStage { get; set; } = null!;

    public virtual UserGroup WorkFlowUserGroup { get; set; } = null!;
}

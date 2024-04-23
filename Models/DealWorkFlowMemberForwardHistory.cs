using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealWorkFlowMemberForwardHistory
{
    public long HistoryId { get; set; }

    public long DealId { get; set; }

    public long UserId { get; set; }

    public long UserGroupId { get; set; }

    public long DealStageId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? DealOrderNo { get; set; }

    public virtual Deal Deal { get; set; } = null!;

    public virtual DealStage DealStage { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual UserGroup UserGroup { get; set; } = null!;
}

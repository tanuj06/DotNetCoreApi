using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealWorkFlowParticipantHistory
{
    public long ParticipantHistoryId { get; set; }

    public long DealId { get; set; }

    public long WorkFlowUserId { get; set; }

    public long DealStageId { get; set; }

    public string? DealOrderNo { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? UserGroupId { get; set; }

    public bool IsCurrentParticipant { get; set; }

    public bool IsDealWorkflowMember { get; set; }

    public virtual Deal Deal { get; set; } = null!;

    public virtual DealStage DealStage { get; set; } = null!;

    public virtual User WorkFlowUser { get; set; } = null!;
}

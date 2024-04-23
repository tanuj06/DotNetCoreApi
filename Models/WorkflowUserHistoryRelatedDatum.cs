using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class WorkflowUserHistoryRelatedDatum
{
    public long? ParticipantHistoryId { get; set; }

    public long? DealId { get; set; }

    public long? DealStageId { get; set; }

    public long? WorkFlowUserId { get; set; }

    public string? GroupName { get; set; }

    public string? DealStage { get; set; }

    public string? ParticipantName { get; set; }

    public string? CreatedBy { get; set; }

    public string? Tat { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ExitDate { get; set; }
}

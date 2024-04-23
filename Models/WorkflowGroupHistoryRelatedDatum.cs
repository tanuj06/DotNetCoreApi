using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class WorkflowGroupHistoryRelatedDatum
{
    public long? GroupHistoryId { get; set; }

    public long? DealId { get; set; }

    public string? DealStageId { get; set; }

    public string? DealStage { get; set; }

    public string? CreatedBy { get; set; }

    public string? GroupName { get; set; }

    public string? Tat { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ExitDate { get; set; }
}

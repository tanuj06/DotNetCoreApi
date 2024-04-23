using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class StageHistoryRelatedDatum
{
    public long DealId { get; set; }

    public long DealStageId { get; set; }

    public string? DealStage { get; set; }

    public long? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? DealStageExitDate { get; set; }

    public string? Tat { get; set; }
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealStageModel
{
    public long DealStageModelId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool? IsDefault { get; set; }

    public string? Crmcode { get; set; }

    public double? Sequence { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<DealStage> DealStages { get; set; } = new List<DealStage>();
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveHurdleTemplate
{
    public int HurdleTemplateId { get; set; }

    public string Name { get; set; } = null!;

    public decimal MinScorecardPercentageEligibleForIncentive { get; set; }

    public decimal? MinimumAchievedPercentage { get; set; }

    public decimal? DeductionPercentage { get; set; }

    public decimal? WeightedScoreCardCap { get; set; }

    public int? CategoryId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public long? OrganisationId { get; set; }

    public DateTime? ServerDateTime { get; set; }
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveCreditCardTier
{
    public long CreditCardTierId { get; set; }

    public string? Name { get; set; }

    public int? MinNoOfCards { get; set; }

    public int? MaxNoOfCards { get; set; }

    public decimal? TierPercentage { get; set; }

    public long? IncentiveCreditCardTierGroupId { get; set; }

    public long? OrganisationId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual IncentiveCreditCardTierGroup? IncentiveCreditCardTierGroup { get; set; }

    public virtual Organisation? Organisation { get; set; }
}

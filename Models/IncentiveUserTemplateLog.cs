using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveUserTemplateLog
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public long BranchShare { get; set; }

    public decimal? RoleShare { get; set; }

    public decimal? LsincentiveFactor { get; set; }

    public decimal? LuincentiveFactor { get; set; }

    public decimal? ReferralShare { get; set; }

    public int? CcActivationDuration { get; set; }

    public long? CreditCardTierGroupId { get; set; }

    public int? CcActivationUnit { get; set; }

    public string? TemplateName { get; set; }

    public decimal? BeforeClawbackCap { get; set; }

    public decimal? ClawbackCap { get; set; }

    public decimal? NetIncentiveCap { get; set; }

    public virtual IncentiveCreditCardTierGroup? CreditCardTierGroup { get; set; }
}

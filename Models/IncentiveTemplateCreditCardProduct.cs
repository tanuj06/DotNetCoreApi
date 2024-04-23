using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTemplateCreditCardProduct
{
    public long IncentiveTemplateCreditCardProductId { get; set; }

    public long? IncentiveTemplateId { get; set; }

    public long? ActivationDuration { get; set; }

    public long? CreditCardTierGroupId { get; set; }

    public decimal? Weightage { get; set; }

    public decimal? Target { get; set; }

    public decimal? Vipcsrtarget { get; set; }

    public decimal? Rmtarget { get; set; }

    public bool IsBranchRoleShareApplicable { get; set; }

    public long? ActivationUnit { get; set; }

    public bool? IsOverrideBranchRoleShare { get; set; }

    public decimal? BranchShare { get; set; }

    public decimal? SalesNonSalesRoleShare { get; set; }

    public decimal? ReferralShare { get; set; }

    public decimal? BeforeClawbackCap { get; set; }

    public decimal? ClawbackCap { get; set; }

    public decimal? NetIncentiveCap { get; set; }

    public bool? IsApplicable { get; set; }

    public bool IsCreditCardSecured { get; set; }

    public virtual IncentiveTemplate? IncentiveTemplate { get; set; }
}

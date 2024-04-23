using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTemplateDebitCardProduct
{
    public long IncentiveTemplateDebitCardProductId { get; set; }

    public long? IncentiveTemplateId { get; set; }

    public decimal? Weight { get; set; }

    public long? ActivationUnit { get; set; }

    public long? Duration { get; set; }

    public long? MinNoOfPrimaryActivatedCards { get; set; }

    public decimal? NetIncentiveCap { get; set; }

    public bool? IsBranchRoleShareApplicable { get; set; }

    public long? Target { get; set; }

    public decimal? Csrtarget { get; set; }

    public decimal? Vipcsrtarget { get; set; }

    public decimal? Rmtarget { get; set; }

    public int? IncentiveFor { get; set; }

    public bool? IsApplicable { get; set; }

    public virtual ICollection<IncentiveDebitCardConfiguration> IncentiveDebitCardConfigurations { get; set; } = new List<IncentiveDebitCardConfiguration>();

    public virtual IncentiveTemplate? IncentiveTemplate { get; set; }
}

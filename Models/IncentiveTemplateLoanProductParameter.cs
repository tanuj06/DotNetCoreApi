using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTemplateLoanProductParameter
{
    public long IncentiveTemplateLoanProductParameterId { get; set; }

    public decimal? Target { get; set; }

    public decimal? Vipcsrtarget { get; set; }

    public decimal? Rmtarget { get; set; }

    public decimal? Weight { get; set; }

    public decimal? LoansIncentiveFactor { get; set; }

    public bool? IsLoanSecured { get; set; }

    public long? IncentiveTemplateId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    public bool IsBranchRoleShareApplicable { get; set; }

    public decimal? BranchShare { get; set; }

    public decimal? SalesNonSalesRoleShare { get; set; }

    public decimal? ReferralShare { get; set; }

    public bool? IsOverrideBranchRoleShare { get; set; }

    public decimal? IncentiveAmountCap { get; set; }

    public decimal? MinLoanAmountEligibleForIncentive { get; set; }

    public bool? IsApplicable { get; set; }

    public virtual IncentiveTemplate? IncentiveTemplate { get; set; }
}

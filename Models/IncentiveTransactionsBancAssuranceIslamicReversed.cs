using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsBancAssuranceIslamicReversed
{
    public long IncentiveTransactionsBancAssuranceIslamicReverseId { get; set; }

    public string? BranchCode { get; set; }

    public string? PolicyNumber { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public DateOnly? CommissionDueDate { get; set; }

    public DateOnly? PremiumDueDate { get; set; }

    public string? EmpId { get; set; }

    public decimal? CommissionAmount { get; set; }

    public decimal? NetAnnualPremium { get; set; }

    public decimal? NetFrequentPremium { get; set; }

    public string? Frequency { get; set; }

    public DateOnly? IncentivePaymentDate { get; set; }

    public bool IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public long? IncentiveTemplateProductImportHistoryId { get; set; }

    public bool? IsMoved { get; set; }

    public virtual IncentiveTemplateProductImportHistory? IncentiveTemplateProductImportHistory { get; set; }
}

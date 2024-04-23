using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsBancAssuranceIslamicReversedFinal
{
    public long IncentiveTransactionsBancAssuranceIslamicReversedFinalId { get; set; }

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

    public long? OwnerId { get; set; }
}

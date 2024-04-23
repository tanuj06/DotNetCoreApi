using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsLoanReversedFinal
{
    public long Id { get; set; }

    public string? OldLoanNo { get; set; }

    public string? NewLoanNo { get; set; }

    public decimal? GrossAmount { get; set; }

    public DateOnly TransactionDate { get; set; }

    public string? SellerOracle { get; set; }

    public string? ReferralOracle { get; set; }

    public string? LoanStatus { get; set; }

    public bool? IsSecured { get; set; }

    public string? ClosedLoanOldBranch { get; set; }

    public DateOnly? ClosedLoanMaturityDate { get; set; }

    public string? ClosedLoanProductName { get; set; }

    public string? ClosedLoanProductType { get; set; }

    public bool? InterestRateExceptionFlag { get; set; }

    public bool? AdminFeesExceptionFlag { get; set; }

    public DateOnly? ClosedLoanDisbursementDate { get; set; }

    public long? OwnerId { get; set; }

    public DateOnly? ClosingValueDate { get; set; }

    public decimal? IncentiveAmountBeforeCap { get; set; }

    public decimal? IncentiveAmountCap { get; set; }

    public decimal? IncentiveAmount { get; set; }

    public decimal? ReferralIncentiveAmount { get; set; }

    public virtual User? Owner { get; set; }
}

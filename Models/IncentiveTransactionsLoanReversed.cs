using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsLoanReversed
{
    public long Id { get; set; }

    public string? OldLoanNo { get; set; }

    public string? NewLoanNo { get; set; }

    public string? GrossAmount { get; set; }

    public string TransactionDate { get; set; } = null!;

    public string? SellerOracle { get; set; }

    public string? ReferralOracle { get; set; }

    public string? LoanStatus { get; set; }

    public string? IncentiveSecured { get; set; }

    public string? ClosedLoanOldBranch { get; set; }

    public string? ClosedLoanMaturityDate { get; set; }

    public string? ClosedLoanProductName { get; set; }

    public string? ClosedLoanProductType { get; set; }

    public string? InterestRateExceptionFlag { get; set; }

    public string? AdminFeesExceptionFlag { get; set; }

    public string? ClosedLoanDisbursementDate { get; set; }

    public string? ClosingValueDate { get; set; }

    public bool? IsMoved { get; set; }
}

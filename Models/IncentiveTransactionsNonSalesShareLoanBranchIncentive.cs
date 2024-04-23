using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsNonSalesShareLoanBranchIncentive
{
    public long Id { get; set; }

    public string? BranchCode { get; set; }

    public string? LoanNo { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public decimal? IncentiveAmount { get; set; }
}

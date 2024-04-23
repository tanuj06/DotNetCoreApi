using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsNonSalesShareBranchIncentive
{
    public long Id { get; set; }

    public string? BranchCode { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public decimal? TotalIncentiveAmount { get; set; }
}

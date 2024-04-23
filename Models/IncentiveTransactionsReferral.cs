using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsReferral
{
    public long Id { get; set; }

    public string? ReferralOracleId { get; set; }

    public int? IncentiveProductTypeId { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public string? BranchCode { get; set; }

    public decimal? NetIncentiveAmount { get; set; }
}

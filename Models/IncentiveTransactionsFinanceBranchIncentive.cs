using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsFinanceBranchIncentive
{
    public long Id { get; set; }

    public string? BranchName { get; set; }

    public string? BranchCode { get; set; }

    public string? Sequence { get; set; }

    public int? Month { get; set; }

    public string? MonthName { get; set; }

    public int? Year { get; set; }

    public string? YearName { get; set; }

    public string? Glno { get; set; }

    public string? Currency { get; set; }

    public string? Amount { get; set; }

    public string? Transaction { get; set; }

    public string? Description { get; set; }

    public string? Constant1 { get; set; }

    public string? Constant2 { get; set; }

    public string? Constant3 { get; set; }

    public string? Constant4 { get; set; }
}

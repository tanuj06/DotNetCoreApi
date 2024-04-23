using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsPayrollFinal
{
    public long IncentiveTransactionsPayrollFinalId { get; set; }

    public string? BranchNumber { get; set; }

    public string? BranchName { get; set; }

    public string? Area { get; set; }

    public string? CompanyCode { get; set; }

    public string? CompanyName { get; set; }

    public long? NoOfAccountAchieved { get; set; }

    public DateOnly? TransactionDate { get; set; }

    public string? BmemployeeId { get; set; }

    public string? DbmemployeeId { get; set; }

    public long? BmuserId { get; set; }

    public long? DbmuserId { get; set; }
}

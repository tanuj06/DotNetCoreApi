using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsPayroll
{
    public long IncentiveTransactionsPayrollId { get; set; }

    public string? BranchNumber { get; set; }

    public string? BranchName { get; set; }

    public string? Area { get; set; }

    public string? CompanyCode { get; set; }

    public string? CompanyName { get; set; }

    public long? NoOfAccountAchieved { get; set; }

    public DateOnly? TransactionDate { get; set; }

    public string? BmemployeeId { get; set; }

    public string? DbmemployeeId { get; set; }

    public bool IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public long? IncentiveTemplateProductImportHistoryId { get; set; }

    public bool? IsMoved { get; set; }

    public virtual IncentiveTemplateProductImportHistory? IncentiveTemplateProductImportHistory { get; set; }
}

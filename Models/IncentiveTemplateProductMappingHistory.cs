using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTemplateProductMappingHistory
{
    public long HistoryId { get; set; }

    public string? CompanyName { get; set; }

    public string? PolicyNumber { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public DateOnly? CommissionDueDate { get; set; }

    public long? ClientId { get; set; }

    public string? ClientName { get; set; }

    public decimal? PolicyAmount { get; set; }

    public decimal? CommissionAmount { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public string? EmployeeNumber { get; set; }

    public long? IncentiveTemplateProductImportHistoryId { get; set; }

    public long IncentiveTransactionsBancAssuranceIslamicId { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual IncentiveTemplateProductImportHistory? IncentiveTemplateProductImportHistory { get; set; }
}

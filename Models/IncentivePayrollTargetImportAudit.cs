using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentivePayrollTargetImportAudit
{
    public long PayrollTargetImportAuditId { get; set; }

    public long? OldImportHistoryId { get; set; }

    public long? NewImportHistoryId { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public long? IncentivePayrollProductConfigurationId { get; set; }

    public virtual IncentivePayrollTarget? IncentivePayrollProductConfiguration { get; set; }

    public virtual IncentivePayrollTargetImportHistory? NewImportHistory { get; set; }

    public virtual IncentivePayrollTargetImportHistory? OldImportHistory { get; set; }
}

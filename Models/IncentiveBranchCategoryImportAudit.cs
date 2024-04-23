using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveBranchCategoryImportAudit
{
    public long IncentiveBranchCategoryImportAuditId { get; set; }

    public long? OldImportHistoryId { get; set; }

    public long? NewImportHistoryId { get; set; }

    public long IncentiveBranchCategoryImportId { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public virtual IncentiveBranchCategory IncentiveBranchCategoryImport { get; set; } = null!;

    public virtual IncentiveBranchCategoryImportHistory? NewImportHistory { get; set; }

    public virtual IncentiveBranchCategoryImportHistory? OldImportHistory { get; set; }
}

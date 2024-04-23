using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealImportAudit
{
    public long DealImportAuditId { get; set; }

    public long? OldImportHistoryId { get; set; }

    public long? NewImportHistoryId { get; set; }

    public long DealId { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public virtual Deal Deal { get; set; } = null!;

    public virtual DealImportHistory? NewImportHistory { get; set; }

    public virtual DealImportHistory? OldImportHistory { get; set; }
}

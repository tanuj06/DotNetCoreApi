using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ActivityImportAudit
{
    public long ActivityImportAuditId { get; set; }

    public long? OldImportHistoryId { get; set; }

    public long? NewImportHistoryId { get; set; }

    public long ActivityId { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual ActivityImportHistory? NewImportHistory { get; set; }

    public virtual ActivityImportHistory? OldImportHistory { get; set; }
}

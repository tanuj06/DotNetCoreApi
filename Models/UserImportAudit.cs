using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserImportAudit
{
    public long UserImportAuditId { get; set; }

    public long? OldImportHistoryId { get; set; }

    public long? NewImportHistoryId { get; set; }

    public long UserId { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public virtual UserImportHistory? NewImportHistory { get; set; }

    public virtual UserImportHistory? OldImportHistory { get; set; }

    public virtual User User { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactImportAudit
{
    public long ContactImportAuditId { get; set; }

    public long? OldImportHistoryId { get; set; }

    public long? NewImportHistoryId { get; set; }

    public long ContactId { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public virtual Contact Contact { get; set; } = null!;

    public virtual ContactImportHistory? NewImportHistory { get; set; }

    public virtual ContactImportHistory? OldImportHistory { get; set; }
}

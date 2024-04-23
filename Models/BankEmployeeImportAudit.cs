using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class BankEmployeeImportAudit
{
    public long BankEmployeeImportAuditId { get; set; }

    public long? OldImportHistoryId { get; set; }

    public long? NewImportHistoryId { get; set; }

    public long BankEmployeeImportId { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public virtual BankEmployeeImportHistory? NewImportHistory { get; set; }

    public virtual BankEmployeeImportHistory? OldImportHistory { get; set; }
}

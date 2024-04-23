using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTemplateProductImportAudit
{
    public long IncentiveTemplateProductAuditId { get; set; }

    public long? OldImportHistoryId { get; set; }

    public long? NewImportHistoryId { get; set; }

    public long IncentiveTransactionsBancAssuranceIslamicId { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public long? ProductTypeId { get; set; }

    public virtual IncentiveTemplateProductImportHistory? NewImportHistory { get; set; }

    public virtual IncentiveTemplateProductImportHistory? OldImportHistory { get; set; }
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveCategoryRoleTemplateMappingImportAudit
{
    public long IncentiveCategoryRoleTemplateMappingImportAuditId { get; set; }

    public long? OldImportHistoryId { get; set; }

    public long? NewImportHistoryId { get; set; }

    public long IncentiveCategoryRoleTemplateMappingImportId { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public virtual IncentiveCategoryRoleTemplateMapping IncentiveCategoryRoleTemplateMappingImport { get; set; } = null!;

    public virtual IncentiveCategoryRoleTemplateMappingImportHistory? NewImportHistory { get; set; }

    public virtual IncentiveCategoryRoleTemplateMappingImportHistory? OldImportHistory { get; set; }
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class RoleDesignationMappingImportAudit
{
    public long RoleDesignationMappingImportAuditId { get; set; }

    public long? OldImportHistoryId { get; set; }

    public long? NewImportHistoryId { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public int? RoleDesignationMappingId { get; set; }

    public virtual RoleDesignationMappingImportHistory? NewImportHistory { get; set; }

    public virtual RoleDesignationMappingImportHistory? OldImportHistory { get; set; }

    public virtual RoleDesignationMapping? RoleDesignationMapping { get; set; }
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class RoleDesignationMappingImportHistory
{
    public long RoleDesignationMappingImportHistoryId { get; set; }

    public long? OrganisationId { get; set; }

    public DateTime ImportTimeStamp { get; set; }

    public string FileName { get; set; } = null!;

    public bool? IsReverted { get; set; }

    public string? Status { get; set; }

    public int? UploadedBy { get; set; }

    public DateTime? UploadedOn { get; set; }

    public string? UploadedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Organisation? Organisation { get; set; }

    public virtual ICollection<RoleDesignationMappingImportAudit> RoleDesignationMappingImportAuditNewImportHistories { get; set; } = new List<RoleDesignationMappingImportAudit>();

    public virtual ICollection<RoleDesignationMappingImportAudit> RoleDesignationMappingImportAuditOldImportHistories { get; set; } = new List<RoleDesignationMappingImportAudit>();

    public virtual ICollection<RoleDesignationMappingImportMapping> RoleDesignationMappingImportMappings { get; set; } = new List<RoleDesignationMappingImportMapping>();
}

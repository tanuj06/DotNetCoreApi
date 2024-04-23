using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class RoleDesignationMapping
{
    public int RoleDesignationMappingId { get; set; }

    public long RoleId { get; set; }

    public long DesignationId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public bool? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public long? RoleDesignationMappingImportHistoryId { get; set; }

    public virtual Designation Designation { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<RoleDesignationMappingImportAudit> RoleDesignationMappingImportAudits { get; set; } = new List<RoleDesignationMappingImportAudit>();
}

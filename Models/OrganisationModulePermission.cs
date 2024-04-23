using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class OrganisationModulePermission
{
    public long OrganisationModulePermissionId { get; set; }

    public long OrganisationId { get; set; }

    public long ModuleId { get; set; }

    public bool CanView { get; set; }

    public bool CanAdd { get; set; }

    public bool CanEdit { get; set; }

    public bool CanDelete { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual Module Module { get; set; } = null!;

    public virtual Organisation Organisation { get; set; } = null!;
}

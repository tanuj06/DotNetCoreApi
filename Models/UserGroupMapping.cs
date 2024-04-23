using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserGroupMapping
{
    public long UserGroupMappingId { get; set; }

    public long UserGroupId { get; set; }

    public long? UserGroupIdasSubGroup { get; set; }

    public long? OrganisationIdasSubGroup { get; set; }

    public long? UserId { get; set; }

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

    public virtual Organisation? OrganisationIdasSubGroupNavigation { get; set; }

    public virtual User? User { get; set; }

    public virtual UserGroup UserGroup { get; set; } = null!;

    public virtual UserGroup? UserGroupIdasSubGroupNavigation { get; set; }
}

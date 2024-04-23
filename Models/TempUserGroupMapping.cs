using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class TempUserGroupMapping
{
    public long Id { get; set; }

    public long? UserGroupMappingId { get; set; }

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
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class RoleMenuMapping
{
    public int RoleMenuMappingId { get; set; }

    public long RoleId { get; set; }

    public int MenuId { get; set; }

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

    public virtual Menu Menu { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}

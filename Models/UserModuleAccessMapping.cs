using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserModuleAccessMapping
{
    public long UserModuleAccessMappingId { get; set; }

    public long UserId { get; set; }

    public long? AccessToUserId { get; set; }

    public bool CanAccessMyReportee { get; set; }

    public long ModuleId { get; set; }

    public bool CanView { get; set; }

    public bool CanAdd { get; set; }

    public bool CanDelete { get; set; }

    public bool? CanEdit { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual User? AccessToUser { get; set; }

    public virtual Module Module { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}

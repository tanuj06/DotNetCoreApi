using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealAttendee
{
    public long DealAttendeeId { get; set; }

    public long? DealId { get; set; }

    public long? AttendeeId { get; set; }

    public bool? IsContact { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Deal? Deal { get; set; }
}

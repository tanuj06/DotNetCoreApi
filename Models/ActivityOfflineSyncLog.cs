using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ActivityOfflineSyncLog
{
    public long ActivityOfflineSyncLogId { get; set; }

    public long? ActivityId { get; set; }

    public string? DeviceObjId { get; set; }

    public string? StatusCode { get; set; }

    public string? Message { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Activity? Activity { get; set; }
}

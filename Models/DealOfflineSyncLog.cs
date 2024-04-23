using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealOfflineSyncLog
{
    public long DealOfflineSyncLogId { get; set; }

    public long? DealId { get; set; }

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

    public virtual Deal? Deal { get; set; }
}

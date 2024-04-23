using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactUnTaggedHistory
{
    public long ContactUnTaggedHistoryId { get; set; }

    public long? UserId { get; set; }

    public long? ContactId { get; set; }

    public string? DeviceObjectId { get; set; }

    public string? Remarks { get; set; }

    public long? UnTaggedBy { get; set; }

    public DateTime? UnTaggedDate { get; set; }

    public virtual User? User { get; set; }
}

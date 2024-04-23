using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealUnTaggedHistory
{
    public long DealUnTaggedHistoryId { get; set; }

    public long? UserId { get; set; }

    public long? DealId { get; set; }

    public string? DeviceObjectId { get; set; }

    public string? Remarks { get; set; }

    public long? UnTaggedBy { get; set; }

    public DateTime? UnTaggedDate { get; set; }

    public virtual User? User { get; set; }
}

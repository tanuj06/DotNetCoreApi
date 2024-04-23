using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ActivityUnTaggedHistory
{
    public long ActivityUnTaggedHistoryId { get; set; }

    public long? UserId { get; set; }

    public long? ActivityId { get; set; }

    public string? Remarks { get; set; }

    public long? UnTaggedBy { get; set; }

    public DateTime? UnTaggedDate { get; set; }

    public virtual User? User { get; set; }
}

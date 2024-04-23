using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ProductUnTaggedHistory
{
    public long ProductUnTaggedHistoryId { get; set; }

    public long? UserId { get; set; }

    public string? Module { get; set; }

    public long? EntityId { get; set; }

    public string? Remarks { get; set; }

    public long? UnTaggedBy { get; set; }

    public DateTime? UnTaggedDate { get; set; }

    public virtual User? User { get; set; }
}

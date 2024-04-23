using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserUnTaggedHistory
{
    public long UserUnTaggedHistoryId { get; set; }

    public long Id { get; set; }

    public long? UserId { get; set; }

    public string? DeviceObjectId { get; set; }

    public string? Remarks { get; set; }

    public long? UnTaggedBy { get; set; }

    public DateTime? UnTaggedDate { get; set; }

    public virtual User? UnTaggedByNavigation { get; set; }
}

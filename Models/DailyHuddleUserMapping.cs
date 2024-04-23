using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DailyHuddleUserMapping
{
    public long DailyHuddleUserMappingId { get; set; }

    public long? HuddleId { get; set; }

    public long? UserId { get; set; }

    public bool IsPresent { get; set; }

    public bool IsMember { get; set; }

    public virtual DailyHuddle? Huddle { get; set; }

    public virtual User? User { get; set; }
}

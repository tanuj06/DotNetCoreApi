using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ActivityStatus
{
    public int ActivityStatusId { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();
}

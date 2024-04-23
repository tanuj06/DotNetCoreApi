using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DailyHuddleType
{
    public long HuddleTypeId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<DailyHuddle> DailyHuddles { get; set; } = new List<DailyHuddle>();
}

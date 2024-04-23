using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class AlertCategory
{
    public long AlertCategoryId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Alert> Alerts { get; set; } = new List<Alert>();
}

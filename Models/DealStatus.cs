using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealStatus
{
    public long DealStatusId { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealOwnerHistory
{
    public long DealOwnerHistoryId { get; set; }

    public long DealId { get; set; }

    public long OwnerId { get; set; }

    public DateTime AssignedOn { get; set; }

    public virtual Deal Deal { get; set; } = null!;

    public virtual User Owner { get; set; } = null!;
}

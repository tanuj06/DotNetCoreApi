using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserLocationHistory
{
    public int UserLocationHistoryId { get; set; }

    public long? UserId { get; set; }

    public string? Location { get; set; }

    public string? LatLongCoordinate { get; set; }

    public DateTime? LastModifiedOn { get; set; }

    public virtual User? User { get; set; }
}

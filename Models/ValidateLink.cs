using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ValidateLink
{
    public int LinkId { get; set; }

    public string? ActionName { get; set; }

    public long UserId { get; set; }

    public DateTime TimeStamp { get; set; }

    public bool IsValidLink { get; set; }

    public virtual User User { get; set; } = null!;
}

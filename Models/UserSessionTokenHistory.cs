using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserSessionTokenHistory
{
    public long UserSessionTokenId { get; set; }

    public long? UserId { get; set; }

    public string? SessionToken { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LogOnDateTime { get; set; }
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserSuccessfulLogin
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public DateTime? LastLoginDateTime { get; set; }

    public string? ClientIpaddress { get; set; }

    public string? BrowserName { get; set; }

    public virtual User User { get; set; } = null!;
}

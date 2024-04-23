using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class AduserSyncLog
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long RootOrgId { get; set; }

    public string? UserAdgroup { get; set; }

    public DateTime? LastSyncDateTime { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual Organisation RootOrg { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}

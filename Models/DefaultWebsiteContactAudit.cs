using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DefaultWebsiteContactAudit
{
    public int AuditId { get; set; }

    public long OldUserId { get; set; }

    public long NewUserId { get; set; }
}

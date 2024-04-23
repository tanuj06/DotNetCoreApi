using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DefaultFacebookLeadOwnerAudit
{
    public int AuditId { get; set; }

    public long OldUserId { get; set; }

    public long NewUserId { get; set; }
}

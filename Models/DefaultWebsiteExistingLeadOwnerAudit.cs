using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DefaultWebsiteExistingLeadOwnerAudit
{
    public long AuditId { get; set; }

    public long OldUserId { get; set; }

    public long NewUserId { get; set; }
}

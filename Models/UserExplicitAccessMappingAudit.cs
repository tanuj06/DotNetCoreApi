using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserExplicitAccessMappingAudit
{
    public int AuditId { get; set; }

    public long UserExplicitAccessMappingId { get; set; }

    public long UserId { get; set; }
}

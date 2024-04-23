using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserBranchMappingLog
{
    public long MappingId { get; set; }

    public long? UserId { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public DateTime? ChangedDateTime { get; set; }

    public virtual User? User { get; set; }
}

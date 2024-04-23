using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserManagerMappingLog
{
    public long MappingId { get; set; }

    public long? UserId { get; set; }

    public long? ManagerId { get; set; }

    public DateTime? ChangedDateTime { get; set; }

    public virtual User? Manager { get; set; }

    public virtual User? User { get; set; }
}

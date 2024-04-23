using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserAuthenticationLog
{
    public long UserAuthenticationLogId { get; set; }

    public long? UserId { get; set; }

    public Guid? Token { get; set; }

    public DateTime? LoggedInTime { get; set; }

    public DateTime? LoggedOutTime { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastRequestedTime { get; set; }

    public bool? IsMasterDataUpdated { get; set; }

    public virtual User? User { get; set; }
}

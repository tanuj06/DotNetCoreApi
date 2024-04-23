using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserLoginPasswordHistory
{
    public long HistoryId { get; set; }

    public long UserId { get; set; }

    public bool IsSuccessFulAttempt { get; set; }

    public byte[]? PasswordHash { get; set; }

    public string? PasswordSalt { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public bool? IsPasswordReset { get; set; }

    public string? SourceDetails { get; set; }

    public bool? IsForceReset { get; set; }

    public int? ForceResetBy { get; set; }

    public DateTime? ForceResetOn { get; set; }

    public DateTime? LogOutTime { get; set; }

    public virtual User User { get; set; } = null!;
}

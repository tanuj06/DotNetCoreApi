using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserOtphistory
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Otp { get; set; } = null!;

    public bool IsValid { get; set; }

    public bool IsVerified { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual User User { get; set; } = null!;
}

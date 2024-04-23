using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserPinMapping
{
    public long UserPinMappingId { get; set; }

    public long? UserId { get; set; }

    public string? PinSalt { get; set; }

    public byte[]? PinHash { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual User? User { get; set; }
}

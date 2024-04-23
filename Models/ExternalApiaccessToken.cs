using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ExternalApiaccessToken
{
    public long TokenId { get; set; }

    public string? AccessToken { get; set; }

    public long? ExpiresIn { get; set; }

    public DateTime? IssuedAt { get; set; }

    public string? Scope { get; set; }
}

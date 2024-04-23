using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CrmaccessToken
{
    public long CrmaccessTokenId { get; set; }

    public string? AccessToken { get; set; }

    public long? ExpiresIn { get; set; }

    public string? TokenType { get; set; }

    public DateTime? IssuedAt { get; set; }

    public string? Scope { get; set; }

    public string? Status { get; set; }

    public bool? IsDeleted { get; set; }
}

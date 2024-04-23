using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CrmaccessTokensV2
{
    public long CrmaccessTokenId { get; set; }

    public string? AccessToken { get; set; }

    public int? ExpiresIn { get; set; }

    public DateTime? IssuedOn { get; set; }

    public bool? IsDeleted { get; set; }
}

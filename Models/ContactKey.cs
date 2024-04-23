using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactKey
{
    public long ContactKeyId { get; set; }

    public long ContactTypeId { get; set; }

    public string? Crmcode { get; set; }

    public virtual ContactType ContactType { get; set; } = null!;
}

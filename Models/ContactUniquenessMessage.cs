using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactUniquenessMessage
{
    public long ContactUniquenessMessageId { get; set; }

    public string? MessageFormat { get; set; }
}

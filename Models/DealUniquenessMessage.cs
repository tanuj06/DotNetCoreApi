using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealUniquenessMessage
{
    public long DealUniquenessMessageId { get; set; }

    public string? MessageFormat { get; set; }
}

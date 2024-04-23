using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ProductSchemeRelatedDatum
{
    public long ProductSchemeId { get; set; }

    public string? ProductScheme { get; set; }

    public string? ProductName { get; set; }

    public double? Sequence { get; set; }

    public bool? IsDefault { get; set; }
}

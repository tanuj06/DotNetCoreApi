using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ProductTypeRelatedDatum
{
    public long ProductTypeId { get; set; }

    public string? Name { get; set; }

    public string? ProductName { get; set; }

    public bool? IsDefault { get; set; }
}

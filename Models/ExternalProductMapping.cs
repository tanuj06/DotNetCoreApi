using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ExternalProductMapping
{
    public long ExternalProductMappingId { get; set; }

    public long? ProductId { get; set; }

    public string? ExternalProductCode { get; set; }

    public virtual Product? Product { get; set; }
}

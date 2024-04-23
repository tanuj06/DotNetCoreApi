using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GameProductMapping
{
    public long GameProductMappingId { get; set; }

    public long? GameId { get; set; }

    public long? ProductId { get; set; }

    public virtual Game? Game { get; set; }

    public virtual Product? Product { get; set; }
}

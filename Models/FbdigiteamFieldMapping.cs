using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class FbdigiteamFieldMapping
{
    public long MappingId { get; set; }

    public string? FbfieldName { get; set; }

    public string? DigiteamFieldName { get; set; }
}

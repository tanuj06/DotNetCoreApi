using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ProductFamilyRelatedDatum
{
    public long ProductFamilyId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? DepartMent { get; set; }
}

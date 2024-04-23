using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ProductListRelatedDatum
{
    public long ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string FamilyName { get; set; } = null!;

    public string? OperationsEmail { get; set; }

    public string? Crmcode { get; set; }

    public string? Description { get; set; }
}

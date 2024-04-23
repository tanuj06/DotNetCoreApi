using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Unit
{
    public long UnitId { get; set; }

    public string Name { get; set; } = null!;

    public string? NameOl1 { get; set; }

    public string? NameOl2 { get; set; }

    public long OrganisationId { get; set; }

    public double? Sequence { get; set; }

    public string? Crmcode { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Organisation Organisation { get; set; } = null!;
}

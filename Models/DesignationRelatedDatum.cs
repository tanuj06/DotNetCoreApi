using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DesignationRelatedDatum
{
    public long DesignationId { get; set; }

    public string Name { get; set; } = null!;

    public double? Sequence { get; set; }

    public bool? IsDefault { get; set; }

    public string? ReportingToRole { get; set; }

    public long OrganisationId { get; set; }

    public bool IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}

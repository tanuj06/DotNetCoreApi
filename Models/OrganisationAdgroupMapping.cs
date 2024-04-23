using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class OrganisationAdgroupMapping
{
    public long AdmappingId { get; set; }

    public string? Adgroup { get; set; }

    public long? OrganisationId { get; set; }

    public bool? IsAdmin { get; set; }

    public string? ReportingToGroup { get; set; }

    public bool? RestrictOtherContactSearch { get; set; }

    public bool? IsRestrictedFromOwnership { get; set; }

    public string? WorkflowGroup { get; set; }
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class TempOrganisationAdgroupMapping
{
    public long Id { get; set; }

    public long RoleId { get; set; }

    public long? OrganisationId { get; set; }

    public bool? IsAdmin { get; set; }

    public string? ReportingToGroup { get; set; }

    public bool? RestrictOtherContactSearch { get; set; }

    public bool? IsRestrictedFromOwnership { get; set; }

    public string? WorkflowGroup { get; set; }
}

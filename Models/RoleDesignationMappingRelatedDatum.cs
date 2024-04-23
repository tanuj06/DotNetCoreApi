using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class RoleDesignationMappingRelatedDatum
{
    public long DesignationId { get; set; }

    public string Designation { get; set; } = null!;

    public string? Roles { get; set; }

    public long OrganisationId { get; set; }

    public bool IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}

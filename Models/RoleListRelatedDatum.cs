using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class RoleListRelatedDatum
{
    public long RoleId { get; set; }

    public string Name { get; set; } = null!;

    public string DefaultMenuName { get; set; } = null!;

    public string? Description { get; set; }

    public bool? IsDefault { get; set; }

    public bool IsDeleted { get; set; }

    public long? OrganisationId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}

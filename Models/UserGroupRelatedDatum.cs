using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserGroupRelatedDatum
{
    public long UserGroupId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool? IsDealWorkFlow { get; set; }

    public bool? AutoContactAllocation { get; set; }

    public bool? RestrictOtherContactSearch { get; set; }

    public bool IsRestrictedFromOwnership { get; set; }

    public string? FocalPointUser { get; set; }

    public string? MappedUserNames { get; set; }

    public string? DepartMents { get; set; }

    public string? SubGroups { get; set; }

    public long OrganisationId { get; set; }

    public bool IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}

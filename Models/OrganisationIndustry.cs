using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class OrganisationIndustry
{
    public int IndustryId { get; set; }

    public string? IndustryName { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<Organisation> Organisations { get; set; } = new List<Organisation>();
}

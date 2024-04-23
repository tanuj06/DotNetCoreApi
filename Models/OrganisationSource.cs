using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class OrganisationSource
{
    public int SourceId { get; set; }

    public string? SourceName { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<Organisation> Organisations { get; set; } = new List<Organisation>();
}

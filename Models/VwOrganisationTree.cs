using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class VwOrganisationTree
{
    public long? Deptid { get; set; }

    public string? Organisations { get; set; }

    public long? Parent { get; set; }

    public int? Level { get; set; }

    public string? Treepath { get; set; }
}

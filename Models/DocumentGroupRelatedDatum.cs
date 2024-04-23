using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DocumentGroupRelatedDatum
{
    public long ChecklistGroupId { get; set; }

    public string? GroupName { get; set; }

    public string? Description { get; set; }

    public bool? IsDefault { get; set; }

    public string? DocumentName { get; set; }
}

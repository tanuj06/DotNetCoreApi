using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GameAwardsRelatedDatum
{
    public long DepartmentAwardMappingId { get; set; }

    public long? DepartmentId { get; set; }

    public long? AwardId { get; set; }

    public string? AwardName { get; set; }

    public string? Prize { get; set; }

    public string? Description { get; set; }

    public int? Weightage { get; set; }

    public bool? Enabled { get; set; }
}

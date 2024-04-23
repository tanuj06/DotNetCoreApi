using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GameDepartmentAwardMapping
{
    public long DepartmentAwardMappingId { get; set; }

    public long? DepartmentId { get; set; }

    public long? AwardId { get; set; }

    public string? Description { get; set; }

    public string? Prize { get; set; }

    public int? Weightage { get; set; }

    public bool? Enabled { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public virtual GameAward? Award { get; set; }

    public virtual Organisation? Department { get; set; }
}

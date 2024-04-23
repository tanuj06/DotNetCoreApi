using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserSegmentMapping
{
    public long UserSegmentMappingId { get; set; }

    public long UserId { get; set; }

    public long ContactSegmentId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public int IsDeleted { get; set; }

    public virtual ContactSegment ContactSegment { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}

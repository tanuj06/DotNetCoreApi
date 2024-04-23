using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class VwAaibAllActivity
{
    public long? Id { get; set; }

    public string? CampaignName { get; set; }

    public string? ContactName { get; set; }

    public string? ContactSegment { get; set; }

    public string? CustomerId { get; set; }

    public string? ScheduledDate { get; set; }

    public string? ScheduledTime { get; set; }

    public string? ActivityDoneDate { get; set; }

    public string? ActivityDoneTime { get; set; }

    public string? ActivityType { get; set; }

    public string ActivityStatus { get; set; } = null!;

    public string? ActivityOwnerEmail { get; set; }

    public string? ActivityOwnerBranchName { get; set; }

    public string? ActivityOwnerBranchCode { get; set; }

    public string? ActivityOutcome { get; set; }

    public string? ContactBranchName { get; set; }

    public string? ContactBranchCode { get; set; }

    public string? ActivityCreatedDate { get; set; }

    public long ActivityId { get; set; }
}

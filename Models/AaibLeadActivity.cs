using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class AaibLeadActivity
{
    public long Id { get; set; }

    public DateOnly? ScheduledDate { get; set; }

    public string? ScheduledTime { get; set; }

    public string? ActivityType { get; set; }

    public string? ActivityStage { get; set; }

    public string? ActivityCreatorName { get; set; }

    public string? ActivityCreatorEmail { get; set; }

    public string? ActivityOwnerBranchName { get; set; }

    public string? ActivityOwnerBranchCode { get; set; }

    public string? ContactOfficeNumber { get; set; }

    public string? ContactResidenceNumber { get; set; }

    public string? ActivityLastNote2 { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public long ActivityId { get; set; }

    public string? CustomerId { get; set; }

    public long? ActivityOwnerId { get; set; }

    public DateOnly? ActivityCreatedDate { get; set; }
}

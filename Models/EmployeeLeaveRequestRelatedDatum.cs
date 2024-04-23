using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class EmployeeLeaveRequestRelatedDatum
{
    public long EmployeeLeaveRequestId { get; set; }

    public long? EmployeeId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public long? DefaultFacebookLeadOwnerId { get; set; }

    public long? DefaultWebsiteContactId { get; set; }

    public bool? CanAutoAllocationHappen { get; set; }

    public string ExistingPortfoliosAccessToUserIds { get; set; } = null!;

    public string LeavePurpose { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public string? RequestFor { get; set; }

    public string? RequestByName { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedByName { get; set; }

    public int? RejectedBy { get; set; }

    public DateTime? RejectedDate { get; set; }

    public string? RejectedByName { get; set; }

    public string? ModifiedByName { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ExistingPortfoliosAccessToUserNames { get; set; }

    public string? DefaultFacebookLeadOwner { get; set; }

    public string? DefaultWebsiteContact { get; set; }

    public string? ContactAccessToUserNames { get; set; }

    public string? ActivityAccessToUserNames { get; set; }

    public string? DealAccessToUserNames { get; set; }

    public string? DealStatusNames { get; set; }

    public string? ActivityStatusNames { get; set; }
}

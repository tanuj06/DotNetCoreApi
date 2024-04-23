using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class EmployeeLeaveRequest
{
    public long EmployeeLeaveRequestId { get; set; }

    public long? EmployeeId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string LeavePurpose { get; set; } = null!;

    public string ExistingPortfoliosAccessToUserIds { get; set; } = null!;

    public bool? CanAutoAllocationHappen { get; set; }

    public long? DefaultFacebookLeadOwnerId { get; set; }

    public long? DefaultWebsiteContactId { get; set; }

    public long? DefaultWebsiteExistingLeadOwnerId { get; set; }

    public string? ContactAccessToUserIds { get; set; }

    public string? ActivityAccessToUserIds { get; set; }

    public string? ActivityStatusIds { get; set; }

    public string? DealAccessToUserIds { get; set; }

    public string? DealStatusIds { get; set; }

    public int RequestBy { get; set; }

    public DateTime RequestDate { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public int? RejectedBy { get; set; }

    public DateTime? RejectedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }
}

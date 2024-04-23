using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserMonthlyTarget
{
    public long UserMonthlyTargetId { get; set; }

    public long UserId { get; set; }

    public int? CallCount { get; set; }

    public int? MeetingCount { get; set; }

    public int? ClosedDealCount { get; set; }

    public decimal? ClosedDealRevenue { get; set; }

    public decimal? ClosedDealSize { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual User User { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GamePlayerHistory
{
    public long GamePlayerTransactionHistoryId { get; set; }

    public long? UserId { get; set; }

    public bool? IsAnIndividualPlayer { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public long? CampDoneCallCnt { get; set; }

    public long? NonCampDoneCallCnt { get; set; }

    public long? DoneCallCnt { get; set; }

    public long? CampDoneMeetingCnt { get; set; }

    public long? NonCampDoneMeetingCnt { get; set; }

    public long? DoneMeetingCnt { get; set; }

    public long? CampClosedDealCnt { get; set; }

    public long? NonCampClosedDealCnt { get; set; }

    public long? ClosedDealCnt { get; set; }

    public decimal? CampClosedDealRevenue { get; set; }

    public decimal? NonCampClosedDealRevenue { get; set; }

    public decimal? ClosedDealRevenue { get; set; }

    public decimal? CampClosedDealSize { get; set; }

    public decimal? NonCampClosedDealSize { get; set; }

    public decimal? ClosedDealSize { get; set; }

    public long? AddedDealCnt { get; set; }

    public decimal? AddedDealRevenue { get; set; }

    public decimal? AddedDealSize { get; set; }

    public long? AddedContactCnt { get; set; }

    public long? IgnoreCustomerCnt { get; set; }

    public long? OverdueDealCnt { get; set; }

    public decimal? OverdueActivityCnt { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual User? User { get; set; }
}

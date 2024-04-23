using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GamePlayerStatistic
{
    public long GamePlayerCurrentTransactionId { get; set; }

    public long? GameId { get; set; }

    public long? UserId { get; set; }

    public bool? IsAnIndividualPlayer { get; set; }

    public DateOnly? TransactionDate { get; set; }

    public long? CampDoneCallCnt { get; set; }

    public long? NonCampDoneCallCnt { get; set; }

    public long? DoneCallCnt { get; set; }

    public decimal? PtsPerDoneCall { get; set; }

    public decimal? TotalDoneCallPts { get; set; }

    public long? CampDoneMeetingCnt { get; set; }

    public long? NonCampDoneMeetingCnt { get; set; }

    public long? DoneMeetingCnt { get; set; }

    public decimal? PtsPerDoneMeeting { get; set; }

    public decimal? TotalDoneMeetingPts { get; set; }

    public decimal? TotalActivityPtsBeforeCap { get; set; }

    public decimal? ActivityDoneCap { get; set; }

    public decimal? TotalActivityPtsAfterCap { get; set; }

    public long? CampClosedDealCnt { get; set; }

    public long? NonCampClosedDealCnt { get; set; }

    public long? ClosedDealCnt { get; set; }

    public decimal? PtsPerClosedDealCnt { get; set; }

    public decimal? TotalClosedDealCntPts { get; set; }

    public decimal? CampClosedDealRevenue { get; set; }

    public decimal? NonCampClosedDealRevenue { get; set; }

    public decimal? ClosedDealRevenue { get; set; }

    public decimal? PtsPerClosedDealRevenue { get; set; }

    public decimal? TotalClosedDealRevenuePts { get; set; }

    public decimal? CampClosedDealSize { get; set; }

    public decimal? NonCampClosedDealSize { get; set; }

    public decimal? ClosedDealSize { get; set; }

    public decimal? PtsPerClosedDealSize { get; set; }

    public decimal? TotalClosedDealSizePts { get; set; }

    public decimal? MaximumPerClosedDealPts { get; set; }

    public decimal? TotalClosedDealPtsBeforeCap { get; set; }

    public decimal? ClosedDealCap { get; set; }

    public decimal? TotalClosedDealPtsAfterCap { get; set; }

    public long? AddedDealCnt { get; set; }

    public decimal? PtsPerAddedDealCnt { get; set; }

    public decimal? TotalAddedDealCntPts { get; set; }

    public decimal? AddedDealRevenue { get; set; }

    public decimal? PtsPerAddedDealRevenue { get; set; }

    public decimal? TotalAddedDealRevenuePts { get; set; }

    public decimal? AddedDealSize { get; set; }

    public decimal? PtsPerAddedDealSize { get; set; }

    public decimal? TotalAddedDealSizePts { get; set; }

    public decimal? MaximumPerAddedDealPts { get; set; }

    public decimal? TotalAddedDealPtsBeforeCap { get; set; }

    public decimal? AddedDealCap { get; set; }

    public decimal? TotalAddedDealPtsAfterCap { get; set; }

    public long? AddedContactCnt { get; set; }

    public decimal? PtsPerAddedContact { get; set; }

    public decimal? TotalAddedContactPts { get; set; }

    public decimal? TotalAddedContactPtsBeforeCap { get; set; }

    public decimal? AddedContactCap { get; set; }

    public decimal? TotalAddedContactPtsAfterCap { get; set; }

    public long? TotalCustomerCnt { get; set; }

    public long? IgnoreCustomerCnt { get; set; }

    public decimal? IgnoreCustomerPct { get; set; }

    public decimal? IgnoreCustomerPenaltyPct { get; set; }

    public long? TotalPipelineDealCnt { get; set; }

    public long? OverdueDealCnt { get; set; }

    public decimal? OverdueDealPct { get; set; }

    public decimal? OverdueDealPenaltyPct { get; set; }

    public long? TotalOpenActivityCnt { get; set; }

    public long? OverdueActivityCnt { get; set; }

    public decimal? OverdueActivityPct { get; set; }

    public decimal? OverdueActivityPenaltyPct { get; set; }

    public decimal? CampaignPct { get; set; }

    public decimal? TargetBonusPct { get; set; }

    public decimal? ProductBonusPct { get; set; }

    public decimal? TotalPtsBeforeOverallCap { get; set; }

    public decimal? TotalPtsAfterOverallCap { get; set; }

    public long? NoOfRminTeam { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Game? Game { get; set; }

    public virtual User? User { get; set; }
}

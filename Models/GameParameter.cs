using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GameParameter
{
    public long GameParameterId { get; set; }

    public long? GameId { get; set; }

    public decimal? ActivityDoneCap { get; set; }

    public decimal? PtsPerDoneCall { get; set; }

    public decimal? PtsPerDoneMeeting { get; set; }

    public decimal? ClosedDealCap { get; set; }

    public decimal? MaximumPerClosedDealPts { get; set; }

    public decimal? PtsPerClosedDealCnt { get; set; }

    public decimal? PtsPerClosedDealRevenue { get; set; }

    public decimal? PtsPerClosedDealSize { get; set; }

    public decimal? AddedDealCap { get; set; }

    public decimal? MaximumPerAddedDealPts { get; set; }

    public decimal? PtsPerAddedDealCnt { get; set; }

    public decimal? PtsPerAddedDealRevenue { get; set; }

    public decimal? PtsPerAddedDealSize { get; set; }

    public decimal? AddedContactCap { get; set; }

    public decimal? PtsPerAddedContact { get; set; }

    public virtual Game? Game { get; set; }
}

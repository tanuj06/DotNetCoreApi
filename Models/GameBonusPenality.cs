using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GameBonusPenality
{
    public long GameBonusPenalitiesId { get; set; }

    public long? GameId { get; set; }

    public decimal? IgnoreCustomerPct { get; set; }

    public decimal? OverdueDealPct { get; set; }

    public decimal? OverdueActivityPct { get; set; }

    public decimal? CampaignPct { get; set; }

    public decimal? TargetBonusPct { get; set; }

    public decimal? ProductBonusPct { get; set; }

    public decimal? OnePtEquivalentAmount { get; set; }

    public virtual Game? Game { get; set; }
}

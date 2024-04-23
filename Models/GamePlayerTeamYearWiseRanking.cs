using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GamePlayerTeamYearWiseRanking
{
    public long GameRankingId { get; set; }

    public long? UserId { get; set; }

    public bool? IsAnIndividual { get; set; }

    public long? Year { get; set; }

    public long? Ranking { get; set; }

    public decimal? TotalPoints { get; set; }

    public virtual User? User { get; set; }
}

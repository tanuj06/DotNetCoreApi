using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GamePlayerTeamRanking
{
    public long GameRankingId { get; set; }

    public long? GameId { get; set; }

    public long? UserId { get; set; }

    public bool? IsAnIndividualPlayer { get; set; }

    public int? Ranking { get; set; }

    public decimal? TotalPoints { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public virtual Game? Game { get; set; }

    public virtual User? User { get; set; }
}

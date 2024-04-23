using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GamePlayerTeamAward
{
    public long GameAwardId { get; set; }

    public long? GameId { get; set; }

    public long? UserId { get; set; }

    public bool? IsAnIndividualPlayer { get; set; }

    public long? AwardId { get; set; }

    public DateOnly? AwardDate { get; set; }

    public string? Description { get; set; }

    public int? Weightage { get; set; }

    public virtual GameAward? Award { get; set; }

    public virtual Game? Game { get; set; }

    public virtual User? User { get; set; }
}

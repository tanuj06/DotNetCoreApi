using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Game
{
    public long GameId { get; set; }

    public long? DepartmentId { get; set; }

    public string? Name { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? StatusId { get; set; }

    public string? Description { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual Organisation? Department { get; set; }

    public virtual ICollection<GameBonusPenality> GameBonusPenalities { get; set; } = new List<GameBonusPenality>();

    public virtual ICollection<GameNote> GameNotes { get; set; } = new List<GameNote>();

    public virtual ICollection<GameParameter> GameParameters { get; set; } = new List<GameParameter>();

    public virtual ICollection<GamePlayerStatistic> GamePlayerStatistics { get; set; } = new List<GamePlayerStatistic>();

    public virtual ICollection<GamePlayerTeamAward> GamePlayerTeamAwards { get; set; } = new List<GamePlayerTeamAward>();

    public virtual ICollection<GamePlayerTeamRanking> GamePlayerTeamRankings { get; set; } = new List<GamePlayerTeamRanking>();

    public virtual ICollection<GamePlayerTeamSetUp> GamePlayerTeamSetUps { get; set; } = new List<GamePlayerTeamSetUp>();

    public virtual ICollection<GameProductMapping> GameProductMappings { get; set; } = new List<GameProductMapping>();

    public virtual GameStatus? Status { get; set; }
}

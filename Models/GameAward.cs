using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GameAward
{
    public long AwardId { get; set; }

    public long? AwardCategoryId { get; set; }

    public string? Name { get; set; }

    public bool? IsForTeam { get; set; }

    public virtual GameAwardCategory? AwardCategory { get; set; }

    public virtual ICollection<GameDepartmentAwardMapping> GameDepartmentAwardMappings { get; set; } = new List<GameDepartmentAwardMapping>();

    public virtual ICollection<GamePlayerTeamAward> GamePlayerTeamAwards { get; set; } = new List<GamePlayerTeamAward>();
}

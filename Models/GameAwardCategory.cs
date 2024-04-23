using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GameAwardCategory
{
    public long AwardCategoryId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<GameAward> GameAwards { get; set; } = new List<GameAward>();
}

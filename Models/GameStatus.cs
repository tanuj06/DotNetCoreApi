using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GameStatus
{
    public int GameStatusId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();
}

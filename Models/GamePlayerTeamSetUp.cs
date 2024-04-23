using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GamePlayerTeamSetUp
{
    public long SetUpId { get; set; }

    public long? GameId { get; set; }

    public bool? IsAnIndividualPlayer { get; set; }

    public long? UserId { get; set; }

    public virtual Game? Game { get; set; }

    public virtual User? User { get; set; }
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GameNote
{
    public long GameNoteId { get; set; }

    public long? GameId { get; set; }

    public long? UserId { get; set; }

    public string? Description { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public virtual Game? Game { get; set; }

    public virtual User? User { get; set; }
}

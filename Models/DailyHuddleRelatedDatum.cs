using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DailyHuddleRelatedDatum
{
    public long HuddleId { get; set; }

    public DateOnly? HuddleDate { get; set; }

    public string? HuddleNote { get; set; }

    public string? HuddleType { get; set; }

    public string? HuddleName { get; set; }

    public string? Participants { get; set; }
}

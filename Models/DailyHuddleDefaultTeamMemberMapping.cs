using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DailyHuddleDefaultTeamMemberMapping
{
    public long HuddleDefaultTeamMemberMappingId { get; set; }

    public long? HuddleLeadId { get; set; }

    public long? UserId { get; set; }

    public bool IsPresent { get; set; }

    public virtual User? HuddleLead { get; set; }

    public virtual User? User { get; set; }
}

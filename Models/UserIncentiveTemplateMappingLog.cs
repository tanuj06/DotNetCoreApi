using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserIncentiveTemplateMappingLog
{
    public long MappingId { get; set; }

    public long? UserId { get; set; }

    public long? IncentiveTemplateId { get; set; }

    public DateTime? ChangedDateTime { get; set; }

    public virtual IncentiveTemplate? IncentiveTemplate { get; set; }

    public virtual User? User { get; set; }
}

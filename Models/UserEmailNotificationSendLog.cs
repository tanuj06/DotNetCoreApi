using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserEmailNotificationSendLog
{
    public long Id { get; set; }

    public DateOnly? LogDate { get; set; }

    public long? UserId { get; set; }

    public bool? ForTeam { get; set; }

    public int? ReportNameId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual User? User { get; set; }
}

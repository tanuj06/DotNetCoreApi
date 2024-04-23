using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserEmailNotificationConfiguration
{
    public int UserEmailNotificationConfigurationId { get; set; }

    public long UserId { get; set; }

    public bool ForTeam { get; set; }

    public int ReportNameId { get; set; }

    public int EmailFrequencyId { get; set; }

    public bool CanSubscribe { get; set; }

    public bool? ShowLastWeekData { get; set; }

    public bool? IsManagerInCc { get; set; }

    public bool? IsParallelAccessUserInCc { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    public virtual EmailFrequency EmailFrequency { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}

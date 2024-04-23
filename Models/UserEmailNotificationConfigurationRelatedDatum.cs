using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserEmailNotificationConfigurationRelatedDatum
{
    public int UserEmailNotificationConfigurationId { get; set; }

    public string UserName { get; set; } = null!;

    public string ReportName { get; set; } = null!;

    public string EmailFrequencyName { get; set; } = null!;

    public bool CanSubscribe { get; set; }

    public bool? IsManagerInCc { get; set; }

    public bool? IsParallelAccessUserInCc { get; set; }

    public long OrganisationId { get; set; }

    public bool IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class EmailFrequency
{
    public int EmailFrequencyId { get; set; }

    public string EmailFrequencyName { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<UserEmailNotificationConfiguration> UserEmailNotificationConfigurations { get; set; } = new List<UserEmailNotificationConfiguration>();
}

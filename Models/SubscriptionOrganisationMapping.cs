using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class SubscriptionOrganisationMapping
{
    public long SubscriptionOrganisationMappingId { get; set; }

    public long? OrganisationId { get; set; }

    public long? SubscriptionTypeId { get; set; }

    public DateTime? SubscriptionDateTime { get; set; }

    public long? UserCount { get; set; }

    public long? RecurringCycle { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public virtual Organisation? Organisation { get; set; }

    public virtual ICollection<SubscriptionTransaction> SubscriptionTransactions { get; set; } = new List<SubscriptionTransaction>();

    public virtual SubscriptionType? SubscriptionType { get; set; }
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class SubscriptionCustomerMapping
{
    public long SubscriptionCustomerMappingId { get; set; }

    public long? OrganisationId { get; set; }

    public string? PayfortCustomerId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public virtual Organisation? Organisation { get; set; }
}

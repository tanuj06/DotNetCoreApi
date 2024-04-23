using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class SubscriptionRedemption
{
    public long SubscriptionRedemptionId { get; set; }

    public long? OrganisationId { get; set; }

    public string? VoucherCode { get; set; }

    public DateTime? RedeemDateTime { get; set; }

    public long? RedeemMonthUnit { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public virtual Organisation? Organisation { get; set; }
}

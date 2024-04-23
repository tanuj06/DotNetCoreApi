using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class SubscriptionTransaction
{
    public long SubscriptionTransactionId { get; set; }

    public long? SubscriptionOrganisationMappingId { get; set; }

    public DateOnly? TransactionDate { get; set; }

    public long? UserCount { get; set; }

    public decimal? AmountPerUserPerMonth { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? CurencyCode { get; set; }

    public long? SubscriptionTransactionStatusId { get; set; }

    public string? PayfortCustomerId { get; set; }

    public string? PayfortChargeId { get; set; }

    public string? Remark { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public virtual SubscriptionOrganisationMapping? SubscriptionOrganisationMapping { get; set; }

    public virtual SubscriptionTransactionStatus? SubscriptionTransactionStatus { get; set; }
}

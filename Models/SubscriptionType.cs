using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class SubscriptionType
{
    public long SubscriptionTypeId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? MonthlyRecurringAmountPerMonth { get; set; }

    public decimal? AnnualRecurringAmountPerMonth { get; set; }

    public string? CurrencyCode { get; set; }

    public long? CamCardScanCount { get; set; }

    public string? StorageSpace { get; set; }

    public bool? IsAttachmentAllowed { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsEnterpriseEdition { get; set; }

    public virtual ICollection<SubscriptionOrganisationMapping> SubscriptionOrganisationMappings { get; set; } = new List<SubscriptionOrganisationMapping>();
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveCreditCardTierGroup
{
    public long CreditCardTierGroupId { get; set; }

    public string? Name { get; set; }

    public long? OrganisationId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<IncentiveCreditCardTier> IncentiveCreditCardTiers { get; set; } = new List<IncentiveCreditCardTier>();

    public virtual ICollection<IncentiveUserTemplateLog> IncentiveUserTemplateLogs { get; set; } = new List<IncentiveUserTemplateLog>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual Organisation? Organisation { get; set; }
}

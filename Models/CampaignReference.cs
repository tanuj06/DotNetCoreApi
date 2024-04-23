using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CampaignReference
{
    public long CampaignReferenceId { get; set; }

    public string? Name { get; set; }

    public long? OrganisationId { get; set; }

    public bool? IsDynamic { get; set; }

    public DateOnly? EndDate { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public string? Crmcode { get; set; }

    public virtual ICollection<ContactCampaignMappingHistory> ContactCampaignMappingHistories { get; set; } = new List<ContactCampaignMappingHistory>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();

    public virtual Organisation? Organisation { get; set; }
}

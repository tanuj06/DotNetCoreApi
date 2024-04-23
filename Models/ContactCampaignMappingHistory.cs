using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactCampaignMappingHistory
{
    public long ContactCampaignMappingHistoryId { get; set; }

    public long? ContactId { get; set; }

    public long? CampaignReferenceId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long? MappedBy { get; set; }

    public bool? IsActive { get; set; }

    public virtual CampaignReference? CampaignReference { get; set; }

    public virtual Contact? Contact { get; set; }
}

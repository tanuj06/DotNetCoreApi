using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveRoleShareTemplate
{
    public long IncentiveRoleShareTemplateId { get; set; }

    public string? Name { get; set; }

    public decimal? BranchShare { get; set; }

    public decimal? SalesNonSalesRoleShare { get; set; }

    public decimal? ReferralShare { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    public bool IsSalesRelatedJob { get; set; }

    public long? OrganisationId { get; set; }

    public virtual ICollection<IncentiveTemplate> IncentiveTemplates { get; set; } = new List<IncentiveTemplate>();
}

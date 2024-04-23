using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveBancAssuranceRole
{
    public long IncentiveBancAssuranceRoleId { get; set; }

    public string? Name { get; set; }

    public decimal? PercentageShare { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    public long? OrganisationId { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

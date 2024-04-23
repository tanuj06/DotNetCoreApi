using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class WorkAddress
{
    public long WorkAddressId { get; set; }

    public string? BranchCode { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long? BankId { get; set; }

    public long? OrganisationId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual Organisation? Organisation { get; set; }

    public virtual ICollection<UserWorkAddressMapping> UserWorkAddressMappings { get; set; } = new List<UserWorkAddressMapping>();
}

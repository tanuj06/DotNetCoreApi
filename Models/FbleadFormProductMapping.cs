using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class FbleadFormProductMapping
{
    public long LeadId { get; set; }

    public long OrganisationId { get; set; }

    public string FbleadFormId { get; set; } = null!;

    public long ProductId { get; set; }

    public bool IsDeleted { get; set; }

    public double? Sequence { get; set; }

    public long CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Organisation Organisation { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}

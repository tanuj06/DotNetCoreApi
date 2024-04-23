using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class OrganisationType
{
    public long OrganisationTypeId { get; set; }

    public string Title { get; set; } = null!;

    public string? TitleOl1 { get; set; }

    public string? TitleOl2 { get; set; }

    public double? Sequence { get; set; }

    public string? Crmcode { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual ICollection<Organisation> Organisations { get; set; } = new List<Organisation>();
}

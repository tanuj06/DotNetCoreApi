using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class OrganisationProductFamilyMapping
{
    public long OrganisationProductFamilyMappingId { get; set; }

    public long? OrganisationId { get; set; }

    public long? SalesMethodId { get; set; }

    public long? ProductFamilyId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual Organisation? Organisation { get; set; }

    public virtual ProductFamily? ProductFamily { get; set; }
}

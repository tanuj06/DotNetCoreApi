using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class OrganisationCurrencyMapping
{
    public long OrganisationCurrencyMappingId { get; set; }

    public long OrganisationId { get; set; }

    public long CurrencyId { get; set; }

    public decimal? ConversionValue { get; set; }

    public long? BaseCurrencyId { get; set; }

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

    public virtual Currency Currency { get; set; } = null!;

    public virtual Organisation Organisation { get; set; } = null!;
}

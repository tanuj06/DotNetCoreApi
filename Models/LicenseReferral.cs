using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class LicenseReferral
{
    public long LicenseReferralId { get; set; }

    public long? ReferredByOrganisationId { get; set; }

    public long? ReferredByUserId { get; set; }

    public string? ReferralCode { get; set; }

    public DateTime? ReferredDate { get; set; }

    public long? ExpiryDuration { get; set; }

    public bool? IsReferralCodeExpired { get; set; }

    public long? ReferredToOrganisationId { get; set; }

    public long? ReferredToUserId { get; set; }

    public string? ReferralEmail { get; set; }

    public DateTime? ReferralCodeUsedDate { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? HubSpotStatusId { get; set; }

    public bool? IsSyncWithHs { get; set; }

    public virtual ICollection<LicenseReferralTransaction> LicenseReferralTransactions { get; set; } = new List<LicenseReferralTransaction>();

    public virtual Organisation? ReferredByOrganisation { get; set; }

    public virtual User? ReferredByUser { get; set; }

    public virtual User? ReferredToUser { get; set; }
}

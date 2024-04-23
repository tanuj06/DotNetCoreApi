using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class LicenseTransaction
{
    public long LicenseTransactionId { get; set; }

    public long? OrganisationId { get; set; }

    public DateTime? TransactionDateTime { get; set; }

    public long? MonthUnits { get; set; }

    public long? LicenseTransationStatusId { get; set; }

    public bool IsNewBillingCycle { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public virtual LicenseTransactionStatus? LicenseTransationStatus { get; set; }

    public virtual Organisation? Organisation { get; set; }
}

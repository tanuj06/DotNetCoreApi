using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentivePayrollTarget
{
    public long IncentivePayrollProductConfigurationId { get; set; }

    public string? Area { get; set; }

    public string? BranchNumber { get; set; }

    public string? BranchName { get; set; }

    public long CompanyTarget { get; set; }

    public long EmployeeTarget { get; set; }

    public string? DeviceObjId { get; set; }

    public long? OrganisationId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public long? PayrollTargetImportHistoryId { get; set; }

    public virtual ICollection<IncentivePayrollTargetImportAudit> IncentivePayrollTargetImportAudits { get; set; } = new List<IncentivePayrollTargetImportAudit>();

    public virtual IncentivePayrollTargetImportHistory? PayrollTargetImportHistory { get; set; }
}

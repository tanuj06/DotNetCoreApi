using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentivePayrollTargetImportHistory
{
    public long PayrollTargetImportHistoryId { get; set; }

    public long? OrganisationId { get; set; }

    public DateTime ImportTimeStamp { get; set; }

    public string FileName { get; set; } = null!;

    public bool? IsReverted { get; set; }

    public string? Status { get; set; }

    public int? UploadedBy { get; set; }

    public DateTime? UploadedOn { get; set; }

    public string? UploadedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<IncentivePayrollTargetImportAudit> IncentivePayrollTargetImportAuditNewImportHistories { get; set; } = new List<IncentivePayrollTargetImportAudit>();

    public virtual ICollection<IncentivePayrollTargetImportAudit> IncentivePayrollTargetImportAuditOldImportHistories { get; set; } = new List<IncentivePayrollTargetImportAudit>();

    public virtual ICollection<IncentivePayrollTargetImportMapping> IncentivePayrollTargetImportMappings { get; set; } = new List<IncentivePayrollTargetImportMapping>();

    public virtual ICollection<IncentivePayrollTarget> IncentivePayrollTargets { get; set; } = new List<IncentivePayrollTarget>();

    public virtual Organisation? Organisation { get; set; }
}

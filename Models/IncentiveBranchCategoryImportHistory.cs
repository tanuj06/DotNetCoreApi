using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveBranchCategoryImportHistory
{
    public long IncentiveBranchCategoryImportHistoryId { get; set; }

    public long? OrganisationId { get; set; }

    public DateTime ImportTimeStamp { get; set; }

    public string FileName { get; set; } = null!;

    public bool? IsReverted { get; set; }

    public string? Status { get; set; }

    public int? UploadedBy { get; set; }

    public DateTime? UploadedOn { get; set; }

    public string? UploadedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<IncentiveBranchCategoryImportAudit> IncentiveBranchCategoryImportAuditNewImportHistories { get; set; } = new List<IncentiveBranchCategoryImportAudit>();

    public virtual ICollection<IncentiveBranchCategoryImportAudit> IncentiveBranchCategoryImportAuditOldImportHistories { get; set; } = new List<IncentiveBranchCategoryImportAudit>();

    public virtual ICollection<IncentiveBranchCategoryImportMapping> IncentiveBranchCategoryImportMappings { get; set; } = new List<IncentiveBranchCategoryImportMapping>();

    public virtual Organisation? Organisation { get; set; }
}

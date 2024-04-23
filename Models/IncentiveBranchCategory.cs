using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveBranchCategory
{
    public long Id { get; set; }

    public string? BranchCode { get; set; }

    public string? Category { get; set; }

    public long? OrganisationId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public string? BranchName { get; set; }

    public long? IncentiveBranchCategoryImportHistoryId { get; set; }

    public virtual ICollection<IncentiveBranchCategoryImportAudit> IncentiveBranchCategoryImportAudits { get; set; } = new List<IncentiveBranchCategoryImportAudit>();
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveCategoryRoleTemplateMapping
{
    public long Id { get; set; }

    public string? Category { get; set; }

    public string? Role { get; set; }

    public long? IncentiveTemplateId { get; set; }

    public long? OrganisationId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public long? IncentiveCategoryRoleTemplateMappingImportHistoryId { get; set; }

    public virtual ICollection<IncentiveCategoryRoleTemplateMappingImportAudit> IncentiveCategoryRoleTemplateMappingImportAudits { get; set; } = new List<IncentiveCategoryRoleTemplateMappingImportAudit>();

    public virtual IncentiveTemplate? IncentiveTemplate { get; set; }
}

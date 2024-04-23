using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ChecklistManagement
{
    public long ChecklistManagementId { get; set; }

    public long? ProductFamilyId { get; set; }

    public long? ProductId { get; set; }

    public long? ProductTypeId { get; set; }

    public long? ProductSchemeId { get; set; }

    public long? CustomerTypeId { get; set; }

    public long? OrganisationId { get; set; }

    public string? Description { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual ICollection<ChecklistManagementDocumentMapping> ChecklistManagementDocumentMappings { get; set; } = new List<ChecklistManagementDocumentMapping>();

    public virtual Organisation? Organisation { get; set; }

    public virtual Product? Product { get; set; }

    public virtual ProductFamily? ProductFamily { get; set; }
}

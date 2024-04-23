using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ChecklistDocument
{
    public long ChecklistDocumentId { get; set; }

    public long? OrganisationId { get; set; }

    public string? DocumentName { get; set; }

    public string? DocumentNameOl1 { get; set; }

    public string? DocumentNameOl2 { get; set; }

    public string? Description { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual ICollection<ChecklistDocumentGroupMapping> ChecklistDocumentGroupMappings { get; set; } = new List<ChecklistDocumentGroupMapping>();

    public virtual ICollection<ChecklistManagementDocumentMapping> ChecklistManagementDocumentMappings { get; set; } = new List<ChecklistManagementDocumentMapping>();

    public virtual ICollection<DealDocumentMapping> DealDocumentMappings { get; set; } = new List<DealDocumentMapping>();

    public virtual Organisation? Organisation { get; set; }
}

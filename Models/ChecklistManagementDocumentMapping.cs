using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ChecklistManagementDocumentMapping
{
    public long ChecklistManagementDocumentMappingId { get; set; }

    public long? ChecklistManagementId { get; set; }

    public long? GroupId { get; set; }

    public long? DocumentId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual ChecklistManagement? ChecklistManagement { get; set; }

    public virtual ChecklistDocument? Document { get; set; }

    public virtual ChecklistGroup? Group { get; set; }
}

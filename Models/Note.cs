using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Note
{
    public long NoteId { get; set; }

    public long? ModuleId { get; set; }

    public long? EntityId { get; set; }

    public long? OrganisationId { get; set; }

    public long? ContactId { get; set; }

    public long? RepresentativeId { get; set; }

    public string? Description { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsDeleteRequestRaised { get; set; }

    public string? DeviceObjId { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public int? SyncStatus { get; set; }

    public int? AddedFromSource { get; set; }

    public string? Crmcode { get; set; }

    public bool? SyncedInCrm { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual Module? Module { get; set; }

    public virtual Organisation? Organisation { get; set; }
}

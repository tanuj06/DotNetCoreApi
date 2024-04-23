using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactRelationshipMapping
{
    public long ContactRelationshipMappingId { get; set; }

    public long ContactId { get; set; }

    public long ContactRelationshipTypeId { get; set; }

    public long? RelationshipWithContactId { get; set; }

    public string? RelationshipWithContactObjId { get; set; }

    public long? OrganisationId { get; set; }

    public double? Sequence { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public int? AddedFromSource { get; set; }

    public virtual Contact Contact { get; set; } = null!;

    public virtual ContactRelationshipType ContactRelationshipType { get; set; } = null!;

    public virtual Organisation? Organisation { get; set; }

    public virtual Contact? RelationshipWithContact { get; set; }
}

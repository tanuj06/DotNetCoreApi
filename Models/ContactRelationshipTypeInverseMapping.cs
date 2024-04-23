using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactRelationshipTypeInverseMapping
{
    public long ContactRelationshipTypeInverseMappingId { get; set; }

    public long? RelationshipTypeId { get; set; }

    public long? InverseRelationshipTypeId { get; set; }

    public long? ContactTypeId { get; set; }

    public long? OrganisationId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual ContactType? ContactType { get; set; }

    public virtual ContactRelationshipType? InverseRelationshipType { get; set; }

    public virtual Organisation? Organisation { get; set; }

    public virtual ContactRelationshipType? RelationshipType { get; set; }
}

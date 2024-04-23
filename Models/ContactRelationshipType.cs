using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactRelationshipType
{
    public long ContactRelationshipTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? NameOl1 { get; set; }

    public string? NameOl2 { get; set; }

    public string? Description { get; set; }

    public long? OrganisationId { get; set; }

    public bool? IsDefault { get; set; }

    public double? Sequence { get; set; }

    public string? Crmcode { get; set; }

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

    public virtual ICollection<ContactRelationshipMapping> ContactRelationshipMappings { get; set; } = new List<ContactRelationshipMapping>();

    public virtual ICollection<ContactRelationshipTypeInverseMapping> ContactRelationshipTypeInverseMappingInverseRelationshipTypes { get; set; } = new List<ContactRelationshipTypeInverseMapping>();

    public virtual ICollection<ContactRelationshipTypeInverseMapping> ContactRelationshipTypeInverseMappingRelationshipTypes { get; set; } = new List<ContactRelationshipTypeInverseMapping>();

    public virtual Organisation? Organisation { get; set; }
}

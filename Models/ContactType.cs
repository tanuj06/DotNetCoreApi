using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactType
{
    public long ContactTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Crmcode { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual ICollection<ContactFieldSetting> ContactFieldSettings { get; set; } = new List<ContactFieldSetting>();

    public virtual ICollection<ContactImportHistory> ContactImportHistories { get; set; } = new List<ContactImportHistory>();

    public virtual ICollection<ContactKey> ContactKeys { get; set; } = new List<ContactKey>();

    public virtual ICollection<ContactRelationshipTypeInverseMapping> ContactRelationshipTypeInverseMappings { get; set; } = new List<ContactRelationshipTypeInverseMapping>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}

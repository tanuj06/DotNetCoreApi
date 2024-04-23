using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactRelationRelatedDatum
{
    public long ContactId { get; set; }

    public long ContactRelationshipTypeId { get; set; }

    public string Type { get; set; } = null!;

    public long? RelationshipWithContactId { get; set; }

    public string ContactName { get; set; } = null!;
}

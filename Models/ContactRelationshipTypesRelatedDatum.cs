using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactRelationshipTypesRelatedDatum
{
    public long ContactRelationshipTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? InverseName { get; set; }

    public bool? IsDefault { get; set; }

    public string? ContactType { get; set; }
}

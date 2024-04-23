using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CommunicationEmailRelatedDatum
{
    public long ContactId { get; set; }

    public long? CommunicationTypeId { get; set; }

    public string Type { get; set; } = null!;

    public string? Email { get; set; }

    public string IsDefault { get; set; } = null!;
}

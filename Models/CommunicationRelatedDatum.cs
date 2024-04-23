using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CommunicationRelatedDatum
{
    public long ContactId { get; set; }

    public long? CommunicationTypeId { get; set; }

    public string? Type { get; set; }

    public string? Email { get; set; }

    public bool? IsDefault { get; set; }
}

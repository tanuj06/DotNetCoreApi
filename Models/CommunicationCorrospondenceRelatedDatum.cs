using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CommunicationCorrospondenceRelatedDatum
{
    public long ContactId { get; set; }

    public long? CorrespondenceTypeId { get; set; }

    public string? Type { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? ZipCode { get; set; }
}

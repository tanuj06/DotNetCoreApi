using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class BasicActivityRelatedDatum
{
    public long ActivityId { get; set; }

    public long? ContactId { get; set; }

    public string ContactName { get; set; } = null!;

    public long? ActivityTypeId { get; set; }

    public string? ActivityType { get; set; }

    public string? ActivitySubject { get; set; }

    public int? ActivityStatusId { get; set; }

    public string? Status { get; set; }

    public long? OwnerId { get; set; }

    public string Owner { get; set; } = null!;

    public string? ActivityDateTime { get; set; }
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class FullActivityRelatedDatum
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

    public string? ActivityReminder { get; set; }

    public string? ActivityDuration { get; set; }

    public long? ActivityClassificationId { get; set; }

    public string? ActivityClassificationName { get; set; }

    public string? ExternalParticipant { get; set; }

    public string? InternalParticipant { get; set; }
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ActivityMappingHistory
{
    public long HistoryId { get; set; }

    public long ContactId { get; set; }

    public long? ActivityTypeId { get; set; }

    public int? ActivityStatusId { get; set; }

    public long? OwnerId { get; set; }

    public long? ActivityClassificationId { get; set; }

    public DateOnly? ActivityDate { get; set; }

    public string? ActivityTime { get; set; }

    public string? ActivityDuration { get; set; }

    public string? ActivityReminderInterval { get; set; }

    public string? ActivityNote { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public string? Field4 { get; set; }

    public string? Field5 { get; set; }

    public string? Field6 { get; set; }

    public string? Field7 { get; set; }

    public string? Field8 { get; set; }

    public string? Field9 { get; set; }

    public string? Field10 { get; set; }

    public string? Field11 { get; set; }

    public string? Field12 { get; set; }

    public string? Field13 { get; set; }

    public string? Field14 { get; set; }

    public string? Field15 { get; set; }

    public string? Field16 { get; set; }

    public string? Field17 { get; set; }

    public string? Field18 { get; set; }

    public string? Field19 { get; set; }

    public string? Field20 { get; set; }

    public long? ActivityImportHistoryId { get; set; }

    public long ActivityId { get; set; }

    public byte? ActivityCallTypeId { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual ActivityImportHistory? ActivityImportHistory { get; set; }

    public virtual Contact Contact { get; set; } = null!;
}

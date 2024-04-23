using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ActivityImportHistory
{
    public long ActivityImportHistoryId { get; set; }

    public long? OrganisationId { get; set; }

    public DateTime ImportTimeStamp { get; set; }

    public string FileName { get; set; } = null!;

    public bool? IsReverted { get; set; }

    public string? Status { get; set; }

    public int? UploadedBy { get; set; }

    public DateTime? UploadedOn { get; set; }

    public string? UploadedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityImportAudit> ActivityImportAuditNewImportHistories { get; set; } = new List<ActivityImportAudit>();

    public virtual ICollection<ActivityImportAudit> ActivityImportAuditOldImportHistories { get; set; } = new List<ActivityImportAudit>();

    public virtual ICollection<ActivityImportMapping> ActivityImportMappings { get; set; } = new List<ActivityImportMapping>();

    public virtual ICollection<ActivityMappingHistory> ActivityMappingHistories { get; set; } = new List<ActivityMappingHistory>();

    public virtual ICollection<ImportHistoryActivitiesMapping> ImportHistoryActivitiesMappings { get; set; } = new List<ImportHistoryActivitiesMapping>();

    public virtual Organisation? Organisation { get; set; }
}

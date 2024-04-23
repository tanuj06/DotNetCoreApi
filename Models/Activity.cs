using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Activity
{
    public long ActivityId { get; set; }

    public long? ActivityTypeId { get; set; }

    public long? ContactId { get; set; }

    public string? ActivitySubject { get; set; }

    public DateOnly? ActivityDate { get; set; }

    public string? ActivityTime { get; set; }

    public string? ActivityDuration { get; set; }

    public string? ActivityReminderInterval { get; set; }

    public bool? IsActivityEvent { get; set; }

    public long? OwnerId { get; set; }

    public long? OwnerOrgId { get; set; }

    public long? CreatorId { get; set; }

    public long? CreatorOrgId { get; set; }

    public byte? ActivityCallTypeId { get; set; }

    public long? ActivityStageId { get; set; }

    public long? RepresentativeId { get; set; }

    public long? EmployerId { get; set; }

    public long? ActivityClassificationId { get; set; }

    public bool? IsConfidential { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsDeleteRequestRaised { get; set; }

    public string? DeviceObjId { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public int? SyncStatus { get; set; }

    public long? AddedFromSource { get; set; }

    public string? DeviceId { get; set; }

    public string? Crmcode { get; set; }

    public bool? SyncedInCrm { get; set; }

    public string? CrmsyncErrorCode { get; set; }

    public string? CrmsyncErrorMessage { get; set; }

    public int? ActivityStatusId { get; set; }

    public string? ActivityActualDuration { get; set; }

    public int? ActivityNoteId { get; set; }

    public long? ActivityImportHistoryId { get; set; }

    public bool? IsEventSent { get; set; }

    public bool? IsPlanned { get; set; }

    public bool? IsOverdue { get; set; }

    public bool? IsDue { get; set; }

    public bool? IsNotYetDue { get; set; }

    public bool? IsDone { get; set; }

    public bool? IsCancelled { get; set; }

    public long? ActivityDoneBy { get; set; }

    public virtual ICollection<ActivityAttendee> ActivityAttendees { get; set; } = new List<ActivityAttendee>();

    public virtual ActivityClassification? ActivityClassification { get; set; }

    public virtual ICollection<ActivityDynamicField> ActivityDynamicFields { get; set; } = new List<ActivityDynamicField>();

    public virtual ICollection<ActivityImportAudit> ActivityImportAudits { get; set; } = new List<ActivityImportAudit>();

    public virtual ActivityImportHistory? ActivityImportHistory { get; set; }

    public virtual ICollection<ActivityOfflineSyncLog> ActivityOfflineSyncLogs { get; set; } = new List<ActivityOfflineSyncLog>();

    public virtual ActivityStage? ActivityStage { get; set; }

    public virtual ActivityStatus? ActivityStatus { get; set; }

    public virtual ActivityType? ActivityType { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual ICollection<ImportHistoryActivitiesMapping> ImportHistoryActivitiesMappings { get; set; } = new List<ImportHistoryActivitiesMapping>();

    public virtual User? Owner { get; set; }
}

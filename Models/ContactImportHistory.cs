using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactImportHistory
{
    public long ContactImportHistoryId { get; set; }

    public long? OrganisationId { get; set; }

    public long? ContactTypeId { get; set; }

    public DateTime ImportTimeStamp { get; set; }

    public string FileName { get; set; } = null!;

    public string? Extension { get; set; }

    public string? MimecontentType { get; set; }

    public byte[]? Contents { get; set; }

    public bool? IsReverted { get; set; }

    public string? Status { get; set; }

    public int? UploadedBy { get; set; }

    public DateTime? UploadedOn { get; set; }

    public string? UploadedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<ContactAssignmentEmailNotificationLog> ContactAssignmentEmailNotificationLogs { get; set; } = new List<ContactAssignmentEmailNotificationLog>();

    public virtual ICollection<ContactImportAudit> ContactImportAuditNewImportHistories { get; set; } = new List<ContactImportAudit>();

    public virtual ICollection<ContactImportAudit> ContactImportAuditOldImportHistories { get; set; } = new List<ContactImportAudit>();

    public virtual ICollection<ContactImportMapping> ContactImportMappings { get; set; } = new List<ContactImportMapping>();

    public virtual ICollection<ContactProductImportAudit> ContactProductImportAuditNewImportHistories { get; set; } = new List<ContactProductImportAudit>();

    public virtual ICollection<ContactProductImportAudit> ContactProductImportAuditOldImportHistories { get; set; } = new List<ContactProductImportAudit>();

    public virtual ContactType? ContactType { get; set; }

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<DealAssignmentEmailNotificationLog> DealAssignmentEmailNotificationLogs { get; set; } = new List<DealAssignmentEmailNotificationLog>();

    public virtual ICollection<ImportHistoryContactMapping> ImportHistoryContactMappings { get; set; } = new List<ImportHistoryContactMapping>();

    public virtual Organisation? Organisation { get; set; }
}

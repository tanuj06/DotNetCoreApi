using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserImportHistory
{
    public long UserImportHistoryId { get; set; }

    public long? OrganisationId { get; set; }

    public DateTime ImportTimeStamp { get; set; }

    public string FileName { get; set; } = null!;

    public bool? IsReverted { get; set; }

    public string? Status { get; set; }

    public int? UploadedBy { get; set; }

    public DateTime? UploadedOn { get; set; }

    public string? UploadedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Organisation? Organisation { get; set; }

    public virtual ICollection<TempUser> TempUsers { get; set; } = new List<TempUser>();

    public virtual ICollection<UserImportAudit> UserImportAuditNewImportHistories { get; set; } = new List<UserImportAudit>();

    public virtual ICollection<UserImportAudit> UserImportAuditOldImportHistories { get; set; } = new List<UserImportAudit>();

    public virtual ICollection<UserImportMapping> UserImportMappings { get; set; } = new List<UserImportMapping>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealImportHistory
{
    public long DealImportHistoryId { get; set; }

    public long? OrganisationId { get; set; }

    public DateTime ImportTimeStamp { get; set; }

    public string FileName { get; set; } = null!;

    public bool? IsReverted { get; set; }

    public string? Status { get; set; }

    public int? UploadedBy { get; set; }

    public DateTime? UploadedOn { get; set; }

    public string? UploadedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<DealAssignmentEmailNotificationLog> DealAssignmentEmailNotificationLogs { get; set; } = new List<DealAssignmentEmailNotificationLog>();

    public virtual ICollection<DealImportAudit> DealImportAuditNewImportHistories { get; set; } = new List<DealImportAudit>();

    public virtual ICollection<DealImportAudit> DealImportAuditOldImportHistories { get; set; } = new List<DealImportAudit>();

    public virtual ICollection<DealImportMapping> DealImportMappings { get; set; } = new List<DealImportMapping>();

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();

    public virtual ICollection<ImportHistoryDealsMapping> ImportHistoryDealsMappings { get; set; } = new List<ImportHistoryDealsMapping>();

    public virtual Organisation? Organisation { get; set; }
}

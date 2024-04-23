using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactProductImportHistory
{
    public long ContactProductImportHistoryId { get; set; }

    public long? OrganisationId { get; set; }

    public DateTime ImportTimeStamp { get; set; }

    public string FileName { get; set; } = null!;

    public bool? IsReverted { get; set; }

    public string? Status { get; set; }

    public int? UploadedBy { get; set; }

    public DateTime? UploadedOn { get; set; }

    public string? UploadedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<ContactProductImportMapping> ContactProductImportMappings { get; set; } = new List<ContactProductImportMapping>();

    public virtual ICollection<ContactProductMappingHistory> ContactProductMappingHistories { get; set; } = new List<ContactProductMappingHistory>();

    public virtual Organisation? Organisation { get; set; }
}

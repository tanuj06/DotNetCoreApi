using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class JobTitleParentJobTitleMappingImportHistory
{
    public long JobTitleParentJobTitleMappingImportHistoryId { get; set; }

    public long? OrganisationId { get; set; }

    public DateTime ImportTimeStamp { get; set; }

    public string FileName { get; set; } = null!;

    public bool? IsReverted { get; set; }

    public string? Status { get; set; }

    public int? UploadedBy { get; set; }

    public DateTime? UploadedOn { get; set; }

    public string? UploadedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<JobTitleParentJobTitleMappingImportMapping> JobTitleParentJobTitleMappingImportMappings { get; set; } = new List<JobTitleParentJobTitleMappingImportMapping>();

    public virtual Organisation? Organisation { get; set; }
}

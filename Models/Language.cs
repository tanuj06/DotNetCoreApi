using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Language
{
    public long LanguageId { get; set; }

    public string? Name { get; set; }

    public string? CultureCode { get; set; }

    public string? FilePath { get; set; }

    public double? Sequence { get; set; }

    public string? Crmcode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }
}

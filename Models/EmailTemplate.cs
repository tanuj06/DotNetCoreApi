using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class EmailTemplate
{
    public long EmailTemplateId { get; set; }

    public string EmailTemplateKey { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public bool? IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public string HeaderTemplateName { get; set; } = null!;

    public string FooterTemplateName { get; set; } = null!;
}

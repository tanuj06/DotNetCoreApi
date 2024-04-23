using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class MasterPageAuditTrail
{
    public int AuditId { get; set; }

    public long? OrganisationId { get; set; }

    public int? ActionedBy { get; set; }

    public DateTime? DateTime { get; set; }

    public string? ActionedOn { get; set; }

    public string? MasterPageName { get; set; }

    public string? ActionType { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }
}

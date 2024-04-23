using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserAuditTrail
{
    public int AuditId { get; set; }

    public long? OrganisationId { get; set; }

    public DateTime? DateTime { get; set; }

    public string? ActionedBy { get; set; }

    public string? ActionedOn { get; set; }

    public long? UserId { get; set; }

    public string? ActionType { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public string? AuditType { get; set; }

    public bool? IsVisible { get; set; }

    public string? RejectionComments { get; set; }

    public virtual Organisation? Organisation { get; set; }

    public virtual User? User { get; set; }
}

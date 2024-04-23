using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Alert
{
    public long AlertId { get; set; }

    public long AlertCategoryId { get; set; }

    public long? ModuleId { get; set; }

    public long? EntityId { get; set; }

    public string? Description { get; set; }

    public long? UserId { get; set; }

    public bool? IsUploaded { get; set; }

    public bool? IsAlert { get; set; }

    public DateOnly? AlertDate { get; set; }

    public DateTime? AlertReadDateTime { get; set; }

    public bool? IsNotification { get; set; }

    public DateTime? NotificationSentDateTime { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public bool? IsDueAlertSent { get; set; }

    public bool? IsReadInPortal { get; set; }

    public DateTime? PortalAlertReadDateTime { get; set; }

    public virtual AlertCategory AlertCategory { get; set; } = null!;

    public virtual User? User { get; set; }
}

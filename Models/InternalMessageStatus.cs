using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class InternalMessageStatus
{
    public long InternalMessageStatusId { get; set; }

    public long? InternalMessageId { get; set; }

    public long? UserId { get; set; }

    public DateTime? ReadDateTime { get; set; }

    public bool? ReadStatus { get; set; }

    public DateTime? DeliverDateTime { get; set; }

    public bool? DeliverStatus { get; set; }

    public virtual InternalMessaging? InternalMessage { get; set; }

    public virtual User? User { get; set; }
}

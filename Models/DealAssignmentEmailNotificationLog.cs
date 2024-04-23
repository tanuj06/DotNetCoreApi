using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealAssignmentEmailNotificationLog
{
    public long Id { get; set; }

    public long? DealId { get; set; }

    public long? ContactImportHistoryId { get; set; }

    public long? DealImportHistoryId { get; set; }

    public long OwnerId { get; set; }

    public long CreatedBy { get; set; }

    public virtual ContactImportHistory? ContactImportHistory { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Deal? Deal { get; set; }

    public virtual DealImportHistory? DealImportHistory { get; set; }

    public virtual User Owner { get; set; } = null!;
}

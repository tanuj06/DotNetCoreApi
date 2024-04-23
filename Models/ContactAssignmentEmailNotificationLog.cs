using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactAssignmentEmailNotificationLog
{
    public long Id { get; set; }

    public long? ContactId { get; set; }

    public long? ContactImportHistoryId { get; set; }

    public long OwnerId { get; set; }

    public long CreatedBy { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual ContactImportHistory? ContactImportHistory { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User Owner { get; set; } = null!;
}

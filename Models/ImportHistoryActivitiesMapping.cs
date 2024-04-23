using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ImportHistoryActivitiesMapping
{
    public long Id { get; set; }

    public long ActivityImportHistoryId { get; set; }

    public long ActivityId { get; set; }

    public long OwnerId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual ActivityImportHistory ActivityImportHistory { get; set; } = null!;

    public virtual User Owner { get; set; } = null!;
}

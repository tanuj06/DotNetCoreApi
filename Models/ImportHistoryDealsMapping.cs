using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ImportHistoryDealsMapping
{
    public long Id { get; set; }

    public long DealImportHistoryId { get; set; }

    public long DealId { get; set; }

    public long OwnerId { get; set; }

    public virtual Deal Deal { get; set; } = null!;

    public virtual DealImportHistory DealImportHistory { get; set; } = null!;

    public virtual User Owner { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class FbleadRetrievalLog
{
    public long LeadRetrievalRequestId { get; set; }

    public DateTime? RequestDate { get; set; }

    public long? TotalLeadsCount { get; set; }

    public long? NewLeadsCount { get; set; }
}

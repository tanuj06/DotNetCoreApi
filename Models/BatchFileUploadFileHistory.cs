using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class BatchFileUploadFileHistory
{
    public long FileHistoryId { get; set; }

    public long TaskHistoryId { get; set; }

    public string FileName { get; set; } = null!;

    public DateTime StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public int? StatusId { get; set; }

    public int? TotalRecordCount { get; set; }

    public int? CompletedRecordCount { get; set; }

    public int? ErrorRecordCount { get; set; }
}

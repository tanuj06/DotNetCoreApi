using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class BatchFileUploadTaskExecutionHistory
{
    public long TaskHistoryId { get; set; }

    public long ScheduleTaskId { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public virtual BatchFileUploadScheduleTask ScheduleTask { get; set; } = null!;
}

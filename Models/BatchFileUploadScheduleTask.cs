using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class BatchFileUploadScheduleTask
{
    public long ScheduleTaskId { get; set; }

    public int TaskType { get; set; }

    public int ModuleId { get; set; }

    public DateTime ScheduledDateTime { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? FrequencyId { get; set; }

    public int? SelectedDay { get; set; }

    public int? SelectedIntervalType { get; set; }

    public DateTime? SelectedIntervalTime { get; set; }

    public int? SelectedInterval { get; set; }

    public int? SelectedIntervalUnit { get; set; }

    public DateTime? LastExecutedDateTime { get; set; }

    public int? StatusId { get; set; }

    public long OrganisationId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<BatchFileUploadTaskExecutionHistory> BatchFileUploadTaskExecutionHistories { get; set; } = new List<BatchFileUploadTaskExecutionHistory>();
}

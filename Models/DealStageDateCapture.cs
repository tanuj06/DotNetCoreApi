using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealStageDateCapture
{
    public long DealStageDateCaptureId { get; set; }

    public long DealId { get; set; }

    public long DealStageId { get; set; }

    public DateTime? DealStageUpdatedDate { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? DealStageExitDate { get; set; }

    public string? DealOrderNo { get; set; }

    public virtual Deal Deal { get; set; } = null!;

    public virtual DealStage DealStage { get; set; } = null!;
}

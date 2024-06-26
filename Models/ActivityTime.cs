﻿using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ActivityTime
{
    public long ActivityTimeId { get; set; }

    public string? Time { get; set; }

    public bool? IsDefault { get; set; }

    public double? Sequence { get; set; }

    public long? OrganisationId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual Organisation? Organisation { get; set; }
}

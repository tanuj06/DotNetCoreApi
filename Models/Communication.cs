using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Communication
{
    public long CommunicationId { get; set; }

    public long ModuleId { get; set; }

    public long EntityId { get; set; }

    public long? CommunicationTypeId { get; set; }

    public string? CommunicationData { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsMandatory { get; set; }

    public string? Crmcode { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public int? AddedFromSource { get; set; }

    public long? ImportHistoryId { get; set; }

    public bool? IsPrimary { get; set; }

    public virtual CommunicationType? CommunicationType { get; set; }

    public virtual Module Module { get; set; } = null!;
}

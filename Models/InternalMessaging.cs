using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class InternalMessaging
{
    public long InternalMessageId { get; set; }

    public long? SendById { get; set; }

    public DateTime? MessageDate { get; set; }

    public string? Description { get; set; }

    public long? SendToId { get; set; }

    public bool? IsGroup { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public string? DeviceObjId { get; set; }

    public virtual ICollection<InternalMessageStatus> InternalMessageStatuses { get; set; } = new List<InternalMessageStatus>();

    public virtual User? SendBy { get; set; }

    public virtual User? SendTo { get; set; }
}

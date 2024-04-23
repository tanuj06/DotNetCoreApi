using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DailyHuddle
{
    public long HuddleId { get; set; }

    public long? HuddleTypeId { get; set; }

    public DateOnly? HuddleDate { get; set; }

    public string? HuddleNote { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<DailyHuddleUserMapping> DailyHuddleUserMappings { get; set; } = new List<DailyHuddleUserMapping>();

    public virtual DailyHuddleType? HuddleType { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }
}

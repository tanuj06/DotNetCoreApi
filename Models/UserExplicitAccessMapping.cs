using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserExplicitAccessMapping
{
    public long UserExplicitAccessMappingId { get; set; }

    public long? UserId { get; set; }

    public long? OtherUserId { get; set; }

    public long? AccessCategoryId { get; set; }

    public bool? CanAccessMyReportee { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual User? OtherUser { get; set; }

    public virtual User? User { get; set; }
}

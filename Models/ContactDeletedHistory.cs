using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactDeletedHistory
{
    public long ContactDeletedHistoryId { get; set; }

    public long? UserId { get; set; }

    public long? ContactId { get; set; }

    public long? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual User? User { get; set; }
}

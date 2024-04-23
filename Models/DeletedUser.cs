using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DeletedUser
{
    public long Id { get; set; }

    public long? OrganisationId { get; set; }

    public long? UserId { get; set; }

    public string? Remark { get; set; }

    public long? DeletedBy { get; set; }

    public DateTime? DeletedOn { get; set; }
}

﻿using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveGranteeType
{
    public long GranteeTypeId { get; set; }

    public string? Name { get; set; }

    public long? OrganisationId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual Organisation? Organisation { get; set; }
}

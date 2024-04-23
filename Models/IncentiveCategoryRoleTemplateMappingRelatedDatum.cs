using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveCategoryRoleTemplateMappingRelatedDatum
{
    public long Id { get; set; }

    public long? IncentiveTemplateId { get; set; }

    public string? CompensationTemplate { get; set; }

    public string? Category { get; set; }

    public string? Role { get; set; }
}

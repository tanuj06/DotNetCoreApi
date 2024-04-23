using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DashboardCirclesConfiguration
{
    public long CircleConfigurationId { get; set; }

    public int CircleType { get; set; }

    public long UserId { get; set; }

    public long DeptId { get; set; }

    public double? Sequence { get; set; }

    public int? TypeId { get; set; }

    public int? FrequencyId { get; set; }

    public long? ProductId { get; set; }

    public long? ProductFamilyId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual Organisation Dept { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}

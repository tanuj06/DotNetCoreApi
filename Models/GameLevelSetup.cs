using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GameLevelSetup
{
    public long GameLevelSetupId { get; set; }

    public long? DepartmentId { get; set; }

    public decimal? StartPoints { get; set; }

    public decimal? EndPoints { get; set; }

    public string? LevelName { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Organisation? Department { get; set; }
}

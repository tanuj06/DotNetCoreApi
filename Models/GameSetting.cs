using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GameSetting
{
    public long GameSettingId { get; set; }

    public long? DepartmentId { get; set; }

    public bool? AutoGameSetup { get; set; }

    public decimal? StepSize { get; set; }

    public decimal? Delta { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Organisation? Department { get; set; }
}

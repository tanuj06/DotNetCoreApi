using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class HubspotUserInitiated
{
    public long Id { get; set; }

    public string? UserName { get; set; }

    public bool? IsSyncWithHs { get; set; }
}

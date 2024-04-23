using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CrmmethodSyncTimeStamp
{
    public int Id { get; set; }

    public string? MethodName { get; set; }

    public DateTime? LastSyncDateTime { get; set; }
}

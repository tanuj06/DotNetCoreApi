using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserDynamicField
{
    public long UserDynamicFieldId { get; set; }

    public long UserId { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public string? Field4 { get; set; }

    public string? Field5 { get; set; }

    public string? Field6 { get; set; }

    public string? Field7 { get; set; }

    public string? Field8 { get; set; }

    public string? Field9 { get; set; }

    public virtual User User { get; set; } = null!;
}

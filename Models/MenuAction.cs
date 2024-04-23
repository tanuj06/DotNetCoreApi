using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class MenuAction
{
    public int MenuActionId { get; set; }

    public int MenuId { get; set; }

    public string ControllerName { get; set; } = null!;

    public string ActionName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public virtual Menu Menu { get; set; } = null!;
}

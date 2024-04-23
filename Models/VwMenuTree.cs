using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class VwMenuTree
{
    public int? Deptid { get; set; }

    public string? Menus { get; set; }

    public int? Parent { get; set; }

    public int? Level { get; set; }

    public string? Treepath { get; set; }
}

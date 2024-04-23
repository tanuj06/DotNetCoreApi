using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class RoleMenuMappingMakerChecker
{
    public long Id { get; set; }

    public long RoleMakerId { get; set; }

    public int MenuId { get; set; }
}

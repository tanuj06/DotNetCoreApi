using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public string Name { get; set; } = null!;

    public string? NameOl1 { get; set; }

    public string? NameOl2 { get; set; }

    public int? ParentMenuId { get; set; }

    public string? MenuUrl { get; set; }

    public string? MenuIcon { get; set; }

    public double? Sequence { get; set; }

    public string? Description { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public bool? IsDefaultHomePage { get; set; }

    public bool OnlyForProductOwner { get; set; }

    public bool LimitExternalAccess { get; set; }

    public virtual ICollection<MenuAction> MenuActions { get; set; } = new List<MenuAction>();

    public virtual ICollection<RoleMenuMapping> RoleMenuMappings { get; set; } = new List<RoleMenuMapping>();
}

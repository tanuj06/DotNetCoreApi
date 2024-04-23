using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class TempRoleProductMapping
{
    public long Id { get; set; }

    public long? RoleProductMappingId { get; set; }

    public long RoleId { get; set; }

    public long ProductId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public int IsDeleted { get; set; }
}

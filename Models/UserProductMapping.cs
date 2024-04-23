using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserProductMapping
{
    public long UserProductMappingId { get; set; }

    public long UserId { get; set; }

    public long ProductId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public int IsDeleted { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}

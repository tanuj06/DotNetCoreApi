using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class TempUserProductMapping
{
    public long Id { get; set; }

    public long? UserProductMappingId { get; set; }

    public long UserId { get; set; }

    public long ProductId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }
}

using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class AllowedContactType
{
    public int AllowedContactTypeId { get; set; }

    public string? ContactTypeName { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

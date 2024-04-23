using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactStatus
{
    public int ContactStatusId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}

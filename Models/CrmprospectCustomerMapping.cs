using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CrmprospectCustomerMapping
{
    public long CrmprospectCustomerMappingId { get; set; }

    public long? ContactId { get; set; }

    public string? ProspectCrmcode { get; set; }

    public string? CustomerCrmcode { get; set; }
}

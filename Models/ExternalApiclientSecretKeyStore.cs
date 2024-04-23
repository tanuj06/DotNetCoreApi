using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ExternalApiclientSecretKeyStore
{
    public long ClientIdsecretKeyStoreId { get; set; }

    public string? ClientId { get; set; }

    public string? SecretKey { get; set; }

    public string? Scope { get; set; }
}

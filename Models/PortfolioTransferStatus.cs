using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class PortfolioTransferStatus
{
    public int StatusId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ContactPortfolioTransfer> ContactPortfolioTransfers { get; set; } = new List<ContactPortfolioTransfer>();
}

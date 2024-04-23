using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class RefreshingFetchCount
{
    public long Id { get; set; }

    public long? ModuleId { get; set; }

    public long? CountForRefreshing { get; set; }

    public long? CountForHomePage { get; set; }

    public long? CountForDetailsPage { get; set; }
}

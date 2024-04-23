using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CountryTimeZoneMapping
{
    public long CountryTimeZoneMappingId { get; set; }

    public int? CountryId { get; set; }

    public long? TimeZoneId { get; set; }

    public virtual Country? Country { get; set; }

    public virtual TimeZone? TimeZone { get; set; }
}

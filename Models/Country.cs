using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string CountryCode { get; set; } = null!;

    public string CountryName { get; set; } = null!;

    public string DialCode { get; set; } = null!;

    public string Cssclass { get; set; } = null!;

    public decimal Sequence { get; set; }

    public long? TimeZoneId { get; set; }

    public virtual ICollection<CountryTimeZoneMapping> CountryTimeZoneMappings { get; set; } = new List<CountryTimeZoneMapping>();

    public virtual TimeZone? TimeZone { get; set; }
}

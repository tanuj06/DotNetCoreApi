using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class TimeZone
{
    public long TimeZoneId { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public long TimeDiffInMinutes { get; set; }

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();

    public virtual ICollection<CountryTimeZoneMapping> CountryTimeZoneMappings { get; set; } = new List<CountryTimeZoneMapping>();

    public virtual ICollection<Organisation> Organisations { get; set; } = new List<Organisation>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

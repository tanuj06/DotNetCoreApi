using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class AppLevelEmailNotificationLog
{
    public long Id { get; set; }

    public DateTime LogDate { get; set; }

    public string EmailTemplateKey { get; set; } = null!;
}

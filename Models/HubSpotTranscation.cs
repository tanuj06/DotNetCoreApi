using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class HubSpotTranscation
{
    public int HubSpotId { get; set; }

    public int UserId { get; set; }

    public bool SaAddeduser { get; set; }

    public DateTime? SaAddeduserOn { get; set; }

    public bool SaSignup { get; set; }

    public DateTime? SaSignupOn { get; set; }

    public bool SaSubscribePay { get; set; }

    public DateTime? SaSubscribeOn { get; set; }

    public bool SaEngage { get; set; }

    public DateTime? SaEngageOn { get; set; }

    public bool SaInactive7 { get; set; }

    public DateTime? SaInactive7On { get; set; }

    public bool SaInactive14 { get; set; }

    public DateTime? SaInactive14On { get; set; }

    public bool SaInactive21 { get; set; }

    public DateTime? SaInactive21On { get; set; }

    public bool SaOverdue { get; set; }

    public DateTime? SaOverdueOn { get; set; }

    public bool SaDownloaded { get; set; }

    public DateTime? SaDownloadedOn { get; set; }

    public bool IsSynWithHubSpot { get; set; }

    public DateTime CreatedOn { get; set; }

    public bool IsDeleted { get; set; }
}

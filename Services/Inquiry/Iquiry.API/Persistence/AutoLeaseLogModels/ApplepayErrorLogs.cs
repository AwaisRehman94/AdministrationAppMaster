using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels.Persistence.AutoLeaseLogModels
{
    public partial class ApplepayErrorLogs
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UserId { get; set; }
        public string ErrorDescription { get; set; }
        public string ServerIp { get; set; }
        public string UserAgent { get; set; }
        public string ReferenceId { get; set; }
        public string RequesterUrl { get; set; }
        public string UserIp { get; set; }
    }
}

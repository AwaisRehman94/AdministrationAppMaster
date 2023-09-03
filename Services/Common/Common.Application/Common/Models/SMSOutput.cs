using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Common.Models
{
    /// <summary>
    /// output Model
    /// </summary>
    [JsonObject("outputModel")]
    public class SMSOutput
    {
        /// <summary>
        /// error description
        /// </summary>
        [JsonProperty("errorDescription")]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// error code
        /// </summary>
        [JsonProperty("errorCode")]
        public int ErrorCode { get; set; }
    }
}

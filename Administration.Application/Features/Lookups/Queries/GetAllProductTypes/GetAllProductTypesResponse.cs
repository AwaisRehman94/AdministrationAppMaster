using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Application.Features.Lookups.Queries.GetAllProductTypes
{
    public class GetAllProductTypesResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

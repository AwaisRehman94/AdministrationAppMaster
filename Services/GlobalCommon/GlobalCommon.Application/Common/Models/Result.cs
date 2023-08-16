using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalCommon.Application.Common.Models
{
    public class Result<T> where T : class
    {
        public int ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public T Data { get; set; }
    }
}

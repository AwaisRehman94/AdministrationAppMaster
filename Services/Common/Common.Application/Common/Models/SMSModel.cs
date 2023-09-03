﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Common.Models
{
    public class SMSModel
    {
        public string PhoneNumber { get; set; }
        public string MessageBody { get; set; }
        public string Method { get; set; }
        public string Module { get; set; }
        public string Channel { get; set; }
        public string ReferenceId { get; set; }
    }
}

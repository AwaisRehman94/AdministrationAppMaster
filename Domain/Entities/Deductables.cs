using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquiry.Domain.Entities
{
    public class AutoleasingDeductible
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public bool IsActive { get; set; }
    }
}

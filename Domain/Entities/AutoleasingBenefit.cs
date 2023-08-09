using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquiry.Domain.Entities
{
    public class AutoleasingBenefit
    {
        public int Id { get; set; }

        public short? Code { get; set; }

        public string? EnglishDescription { get; set; }

        public string? ArabicDescription { get; set; }
    }
}

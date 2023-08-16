
using Identity.Domain.Enums;

namespace Identity.Application.Common.Models
{
    public class BaseViewModel
    {
        public string Language { get; set; } = "ar";
        public Channel Channel { get; set; } = Channel.Portal;
    }
}

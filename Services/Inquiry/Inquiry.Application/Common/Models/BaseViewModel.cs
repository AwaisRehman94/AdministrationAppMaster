
using GlobalCommon.Domain.Enums;

namespace Inquiry.Application.Common.Models
{
    public class BaseViewModel
    {
        public string Language { get; set; } = "ar";
        public Channel Channel { get; set; } = Channel.Portal;
    }
}

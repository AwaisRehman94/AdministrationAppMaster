using Common.Domain.Enums;

namespace Common.Domain.Models
{
    public class BaseViewModel
    {
        public string Language { get; set; } = "ar";
        public Channel Channel { get; set; } = Channel.Portal;
    }
}

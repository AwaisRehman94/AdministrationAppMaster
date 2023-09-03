
using Common.Application.Common.Models;

namespace Common.Application.Common.Interfaces.Notifications
{
    public interface ISmsProvider
    {
        SMSOutput SendSmsBySTC(SMSModel model);
        SMSOutput SendSmsByMobiShastra(SMSModel model);
    }
}

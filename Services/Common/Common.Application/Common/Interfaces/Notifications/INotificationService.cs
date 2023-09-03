using Common.Application.Common.Models;


namespace Common.Application.Common.Interfaces.Notifications
{
    public interface INotificationService
    {
        SMSOutput SendSmsBySMSProviderSettings(SMSModel model);
    }
}

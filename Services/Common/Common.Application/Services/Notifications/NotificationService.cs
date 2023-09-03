using Common.Application.Common.Interfaces.Notifications;
using Common.Application.Common.Interfaces.Persistence;
using Common.Application.Common.Models;
using Common.Domain.DomainEntities.Entities.DomainEntities;
using Common.Domain.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Services.Notifications
{
    public class NotificationService : INotificationService
    {
        private readonly IRepository<SmsproviderSettings> smsproviderSettings;

        public NotificationService(IRepository<SmsproviderSettings> repository)
        {
            this.smsproviderSettings = repository;
        }

        public SMSOutput SendSmsBySMSProviderSettings(SMSModel model)
        {
            var SMSProviderSetting = smsproviderSettings.TableNoTracking.Where(sms => sms.Method == model.Method && sms.Module == model.Module).FirstOrDefault();
            model.PhoneNumber = Utilities.ValidatePhoneNumber(model.PhoneNumber);
            if (SMSProviderSetting?.Smsprovider == "STC")
            {
                return null;
            }
            else
            {
                return null;
            }
            return null;
        }
    }
}
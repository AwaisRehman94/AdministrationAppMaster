using Common.Application.Common.Interfaces.Notifications;
using Common.Application.Common.Models;
using Common.Domain.Entities.LogEntities;
using Common.Domain.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Services.Notifications
{
    internal class QyadatSmsProvider : ISmsProvider
    {
        public SMSOutput SendSmsByMobiShastra(SMSModel model)
        {
            throw new NotImplementedException();
        }

        public SMSOutput SendSmsBySTC(SMSModel model)
        {
            Smslog  log = new Smslog();
            SMSOutput output = new SMSOutput();
            log.UserIp = Utilities.GetUserIPAddress();
            log.ServerIp = Utilities.GetInternalServerIP();
            log.UserAgent = Utilities.GetUserAgent();
            log.Smsprovider = "STC";
            log.ServiceUrl = RepositoryConstants.STCSmsServiceUrl;
            log.Method = model.Method;
            log.Module = model.Module;
            log.Channel = model.Channel;
            log.ReferenceId = model.ReferenceId;
            log.MobileNumber = model.PhoneNumber;
            log.Smsmessage = model.MessageBody;
            string request = "{  \"userName\": \"" + RepositoryConstants.STCSmsAccountUsername + "\",  \"numbers\": \"" + model.PhoneNumber + "\",  \"userSender\": \"" + RepositoryConstants.STCSmsAccountSender + "\",  \"apiKey\": \"" + RepositoryConstants.STCSmsApiKey + "\",  \"msg\": \"" + model.MessageBody + "\"}";
            var content = new StringContent(request, System.Text.Encoding.UTF8, "application/json");
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            log.ServiceRequest = request;
            DateTime dtBeforeCalling = DateTime.Now;
            //var response = _httpClient.Post(RepositoryConstants.STCSmsServiceUrl, content);
            //log.ServiceResponseTimeInSeconds = DateTime.Now.Subtract(dtBeforeCalling).TotalSeconds;

            //if (response == null || response.Content == null)
            //{
            //    log.ErrorCode = 13;
            //    log.ErrorDescription = "response from STCSmsProvider is null";
            //}
            //else
            //{
            //    var responseString = response.Content?.ReadAsStringAsync().Result;
            //    log.ServiceResponse = responseString;
            //    STCSmsResponse stcResponse = JsonConvert.DeserializeObject<STCSmsResponse>(responseString);
            //    switch (stcResponse.Code)
            //    {
            //        case "1":
            //        case "M0000": //Success
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.Success;
            //                break;
            //            }
            //        case "M0001":
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.VariablesMissing;
            //                break;
            //            }
            //        case "1010"://Variables missing
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.VariablesMissing;
            //                break;
            //            }
            //        case "M0002":
            //        case "1020"://Invalid login info
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.InvalidLoginInfo;
            //                break;
            //            }
            //        case "M0022": //Exceed number of senders allowed
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.ExceedNumberOfSendersAllowed;
            //                break;
            //            }
            //        case "M0023": //Exceed number of senders allowed
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.SenderNameIsActiveOrUnderActivationOrRefused;
            //                break;
            //            }
            //        case "M0024": //Sender Name should be in English or number
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.SenderNameShouldBeInEnglishOrNumber;
            //                break;
            //            }
            //        case "M0025": //Invalid Sender Name Length
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.InvalidSenderNameLength;
            //                break;
            //            }
            //        case "M0026": //Sender Name is already activated or not found
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.SenderNameIsAlreadyActivatedOrNotFound;
            //                break;
            //            }
            //        case "M0027": //Activation Code is not Correct
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.ActivationCodeIsNotCorrect;
            //                break;
            //            }
            //        case "M0028": //You reach maximum number of attempts. Sender name is locked
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.YouReachMaximumNumberOfAttemptsSenderNameIsLocked;
            //                break;
            //            }
            //        case "M0050": //MSG body is empty
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.MsgBodyIsEmpty;
            //                break;
            //            }
            //        case "M0060": //Balance is not enough
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.BalanceIsNotEnough;
            //                break;
            //            }
            //        case "M0061": //MSG duplicated
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.MsgDuplicated;
            //                break;
            //            }
            //        case "1110": //Sender name is missing or incorrect
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.SenderNameIsMissingOrIncorrect;
            //                break;
            //            }
            //        case "1120": //Mobile numbers is not correct
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.MobileNumbersIsNotCorrect;
            //                break;
            //            }
            //        case "1140": //MSG length is too long
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.MsgLengthIsTooLong;
            //                break;
            //            }
            //        case "M0029": //Invalid Sender Name
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.InvalidSenderName;
            //                break;
            //            }
            //        case "M0030": //Sender Name should ended with AD
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.SenderNameShouldEndedWithAD;
            //                break;
            //            }
            //        case "M0031": //Maximum allowed size of uploaded file is 5 MB
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.MaximumAllowedSizeOfUploadedFileIs5MB;
            //                break;
            //            }
            //        case "M0032": //Only pdf,png,jpg and jpeg files are allowed!
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.FileExtensionNotAllowed;
            //                break;
            //            }
            //        case "M0033": //Sender Type should be normal or whitelist only
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.SenderTypeShouldBeNormalOrWhitelistOnly;
            //                break;
            //            }
            //        case "M0034": //Please Use POST Method
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.PleaseUsePOSTMethod;
            //                break;
            //            }
            //        default:
            //            {
            //                log.ErrorCode = (int)ESTCSmsResponse.GenericError;
            //                break;
            //            }
            //    }
            //    log.ErrorDescription = stcResponse.Message;
            //}
            //output.ErrorCode = log.ErrorCode.Value;
            //output.ErrorDescription = log.ErrorDescription;
            //SMSLogsDataAccess.AddToSMSLogsDataAccess(log);
            return output;
            throw new NotImplementedException();
        }
    }
}

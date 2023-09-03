using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain.Utilities;

public class Utilities
{
    public const string InternationalPhoneCode = "00";
    public const string InternationalPhoneSymbol = "+";
    public const string Zero = "0";
    public const string SaudiInternationalPhoneCode = "966";

    private static IHttpContextAccessor _httpContextAccessor;

    public static void Configure(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }


    /// <summary>
    /// Gets the internal server IP.
    /// </summary>
    /// <returns></returns>
    public static string GetInternalServerIP()
    {
        try
        {
            var feature = _httpContextAccessor.HttpContext.Features.Get<IHttpConnectionFeature>();
            return  feature?.LocalIpAddress?.ToString()!;
        }
        catch (Exception exp)
        {
            return string.Empty;
        }
    }

    /// <summary>
    /// Gets the user agent.
    /// </summary>
    /// <returns></returns>
    public  static string GetUserAgent()
    {
        try
        {
            return _httpContextAccessor.HttpContext.Request.Headers["User-Agent"].ToString();
        }
        catch (Exception exp)
        {
            // ErrorLogger.LogError(exp.Message, exp, false);
            return string.Empty;
        }
    }

    /// <summary>
    /// Gets the user ip address.
    /// </summary>
    /// <returns></returns>
    public static string GetUserIPAddress()
    {
        try
        {
          return   _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }
        catch (Exception exp)
        {
            return string.Empty;
        }
    }

    public static string ValidatePhoneNumber(string phoneNumber)
    {
        if (phoneNumber.StartsWith(InternationalPhoneCode))
            phoneNumber = phoneNumber.Substring(InternationalPhoneCode.Length);
        else if (phoneNumber.StartsWith(InternationalPhoneSymbol))
            phoneNumber = phoneNumber.Substring(InternationalPhoneSymbol.Length);

        if (!phoneNumber.StartsWith(SaudiInternationalPhoneCode))
        {
            if (phoneNumber.StartsWith(Zero))
                phoneNumber = phoneNumber.Substring(Zero.Length);

            phoneNumber = SaudiInternationalPhoneCode + phoneNumber;
        }

        return phoneNumber;
    }
}

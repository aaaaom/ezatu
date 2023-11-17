using System;
namespace WebApplication.Models;
public class UserTokens
{
    public string Token
    {
        get;
        set;
    }
    public string UserName
    {
        get;
        set;
    }
    public TimeSpan Validaty
    {
        get;
        set;
    }
    public string RefreshToken
    {
        get;
        set;
    }
    public Guid Id
    {
        get;
        set;
    }
    
    public DateTime ExpiredTime
    {
        get { return GetExpirationdate(); }
        set { }
    }
    public static DateTime GetExpirationdate()
    {

        //return DateTime.UtcNow.AddHours(1);
        return DateTime.UtcNow.AddMinutes(1);
    }
}
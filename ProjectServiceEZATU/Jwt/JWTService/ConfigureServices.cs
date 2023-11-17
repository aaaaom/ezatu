//using ProjectServiceEZATU.Jwt.JWTModel;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.IdentityModel.Tokens;
//using System;
//using System.Text;

//namespace ProjectServiceEZATU.Jwt.JWTService
//{
//    public void ConfigureServices(IServiceCollection services)
//    {
//        var jwtTokenConfig = Configuration.GetSection("jwtTokenConfig").Get<JwtTokenConfig>();
//        services.AddSingleton(jwtTokenConfig);
//        services.AddAuthentication(x =>
//        {
//            x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//            x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//        }).AddJwtBearer(x =>
//        {
//            x.RequireHttpsMetadata = true;
//            x.SaveToken = true;
//            x.TokenValidationParameters = new TokenValidationParameters
//            {
//                ValidateIssuer = true,
//                ValidIssuer = jwtTokenConfig.Issuer,
//                ValidateIssuerSigningKey = true,
//                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtTokenConfig.Secret)),
//                ValidAudience = jwtTokenConfig.Audience,
//                ValidateAudience = true,
//                ValidateLifetime = true,
//                ClockSkew = TimeSpan.FromMi2nutes(1)
//                ClockSkew = TimeSpan.Zero
//            };
//        });
//        ...
//    }
//}

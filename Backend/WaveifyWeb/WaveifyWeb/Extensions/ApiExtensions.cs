using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Waveify.Infrastructure;
namespace Waveify.API.Extensions
{
    public static class ApiExtensions
    {
        public static void AddMapeedEndpoints(this IEndpointRouteBuilder app)
        {
            // Тут должны быть эндпоинты который запрещает доступ не зарегистрированным пользователям
        }
        public static void AddApiAuthentication(
            this IServiceCollection services,
           IOptions<JwtOptions> jwtOptions
            )
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.TokenValidationParameters = new()
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(jwtOptions.Value.SecretKey))
                    };
                });
            services.AddAuthorization();
            }
    }
}

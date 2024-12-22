using Waveify.API.Contracts;
using Waveify.Application.Services; 
namespace Waveify.API.Endpoints
{
    public static class UserEndpoints
    {
        public static IEndpointRouteBuilder MapUsersEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("api/register", Register);
            app.MapPost("login", Login);
            return app;
        }
        private static async Task<IResult> Register(
            RegisterUserRequest request,UserServices userServices)
        {
            await userServices.Register(request.UserName, request.Email, request.Password);

            return Results.Ok();
        }
        private static async Task<IResult> Login(
            LoginUserRequest request, UserServices userService)
        {
            var token = await userService.Login(request.Email, request.Password);
            return Results.Ok(token);    
        }
       
    }
}

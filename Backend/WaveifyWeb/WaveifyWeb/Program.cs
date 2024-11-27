using Microsoft.EntityFrameworkCore;
using Waveify.Application.Auth;
using Waveify.Application.Interface.Repositiories;
//using Waveify.Application.Interfaces.Repositiories;
//using Waveify.Application.Repositiories;
using Waveify.Application.Services;
using Waveify.Infrastructure;
using Waveify.Interface.Auth;
using Waveify.Persistence;
using Waveify.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IJwtProvider, JwtProvider>();
builder.Services.AddScoped<IPasswordHash, PasswordHash>();
builder.Services.AddScoped<UserServices>();
builder.Services.AddScoped <IUserRepository, Waveify.Persistence.Repositiories.UserRepository>();
builder.Services.AddAutoMapper(typeof(DataBaseMapping));

builder.Services.AddScoped<IDrumKitServices, DrumKitServices>();
builder.Services.AddScoped<IDrumKitRepositories, DrumKitRepositories>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<WaveifyDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(WaveifyDbContext)));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{

    //app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}
//else
//{
//    app.UseExceptionHandler("/Home/Error");
//    app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseCors(x =>
{
    x.WithHeaders().AllowAnyHeader();
    x.WithOrigins("http://193.227.240.115:25432");
    x.WithMethods().AllowAnyMethod();
});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
using Demo.Notifications.Api.Aplication;
using Demo.Notifications.Api.Aplication.NotifyUser;
using Demo.Notifications.Api.Infra.Services;
using MediatR;
using SendGrid.Extensions.DependencyInjection;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var sendGridApiKey = builder.Configuration.GetSection("SendGripApiKey").Value;

builder.Services.AddSendGrid(o => o.ApiKey = sendGridApiKey);

builder.Services.AddScoped<INotificationFactoryFacade, NotificationFactoryFacade>();

builder.Services.AddMediatR(typeof(NotifyUserCommand));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.ConfigureAppConfiguration((hostingContext, config) => {
    Serilog.Log.Logger = new LoggerConfiguration()
        .Enrich.FromLogContext()
        .WriteTo.Console()
        .CreateLogger();
}).UseSerilog();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

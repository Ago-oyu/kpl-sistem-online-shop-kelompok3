using System.Text.Json.Serialization;
using Backend;
using Serilog;

Config config = Config.GetConfig<Config>();
var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((_, serviceProvider, loggerConfiguration) =>
{
    
    loggerConfiguration
        .Enrich.FromLogContext()
        .WriteTo.File($"Logs/Backend.log", outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception} {RequestInfo}"); // {NewLine}input:{NewLine}{RequestBody}{NewLine}output:{NewLine}{ResponseBody}
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers()
    .AddJsonOptions(options => { options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<RequestResponseLoggingMiddleware>();
app.UseSerilogRequestLogging(opts => opts.EnrichDiagnosticContext = LogHelper.EnrichFromRequest);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run($"http://{config.host}:{config.port}");


using Microsoft.EntityFrameworkCore;
using Villa_VillaAPI.Data;
using Villa_VillaAPI.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//SeriLog
//Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
//    .WriteTo.File("Log/villaLogs.txt", rollingInterval:RollingInterval.Day).CreateLogger();

//builder.Host.UseSerilog();

builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
});
builder.Services.AddControllers(option =>
{
    //option.RespectBrowserAcceptHeader = true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using riot.ws.domain.Context;
using riot.ws.infrastructure.Maps;
using riot.ws.service.handlers.Account.AddAccount;
using riot.ws.service.handlers.Account.GetAccount;
using riot.ws.service.handlers.GetMatchHistory;
using riot.ws.service.handlers.GetSpectator;
using riot.ws.domain.Context;
using riot.ws.infrastructure.Maps;
using riot.ws.service.handlers.Account.AddAccount;
using riot.ws.service.handlers.Account.GetAccount;
using riot.ws.service.handlers.GetMatchHistory;
using riot.ws.service.handlers.GetRank;
using riot.ws.service.handlers.GetSpectator;
using riot.ws.shared.infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<PostgresContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("RiotDbConnString");
    options.UseNpgsql(connectionString);
}
, optionsLifetime: ServiceLifetime.Scoped
);

//builder.Services.AddHostedService<ApplicationStartupService>();

builder.Services.AddScoped<GetAccountRiot>();

builder.Services.AddScoped<GetMatchHistoryRiot>();
builder.Services.AddScoped<GetRankRiot>();


builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAccountQueryHandler).Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AddAccountQueryHandler).Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetSpectatorQueryHandler).Assembly));
//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetRankQueryHandler).Assembly));


builder.Services.AddHttpClient();

builder.Services.AddAutoMapper(typeof(ParticipanteMap)); 

builder.Services.AddAutoMapper(typeof(PartidaMap)); 

builder.Services.AddScoped<IObjectMapper, ObjectMapper>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy.WithOrigins("http://localhost:4200") // Cambia esto por el origen de tu frontend
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

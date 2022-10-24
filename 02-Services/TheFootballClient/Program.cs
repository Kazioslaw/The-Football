using Microsoft.EntityFrameworkCore;
using TfcInfrastracture.DbContext;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TheFootballClientContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TheFootballClientContext") ?? throw new InvalidOperationException("Connection string 'TheFootballClientContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
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

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<TheFootballClientContext>();
    context.Database.EnsureCreated();
    //DbInitializer.Initialize(context);
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
using Devices.Application;
using Devices.Application.Utils;
using Devices.Infraestructure;
using Devices.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Configuracion de inyeccion de dependencias

builder.Services.AddDeviceApplication();
builder.Services.AddDeviceInfraestructure();


//SE CONFIGURA AutoMapper que ojo puede cobrar pronto
builder.Services.AddAutoMapper(typeof(DeviceMapperProfile));

//SE CONFIGURA POSTGRES
builder.Services.AddDbContext<DeviceDBContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(Program));

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

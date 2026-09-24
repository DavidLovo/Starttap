using Application.Interfaces;
using Application.Services;
using InfraStruture.Database;
using InfraStruture.Repository;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
var conexion = builder.Configuration.GetConnectionString("default");
builder.Services.AddSingleton(new DBConectionFactory(conexion!));
builder.Services.AddOpenApi();

builder.Services.AddScoped<IProveedorRepository, ProveedorRepository>();
builder.Services.AddScoped<ProveedorService>();

builder.Services.AddSwaggerGen();

builder.Services.AddCors(c => {
    c.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyMethod()
        .AllowAnyHeader()
        .AllowAnyOrigin();
    });

});
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(s =>
{
    s.SwaggerEndpoint("/swagger/v1/swagger.json", "Api ERP");
    s.RoutePrefix = string.Empty;
});


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors("AllowAll");
app.UseAuthorization();

app.MapControllers();

app.Run();

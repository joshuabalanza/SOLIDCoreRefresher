using Microsoft.EntityFrameworkCore;
using APICalculator.App.Interfaces;
using APICalculator.App.Implementation;
using APICalculator.Services.Implementation;
using APICalculator.Services.Interfaces;
using APICalculator.Process.Interfaces;
using APICalculator.Process.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IBasicCalculatorServices, BasicCalculator>();
builder.Services.AddScoped<IScientificCalculatorServices, ScientificCalculator>();

builder.Services.AddTransient<ICalculatorProcess, CalculatorProcess>();
builder.Services.AddScoped<ICalculatorServices, BasicCalculatorServices>();
builder.Services.AddScoped<ICalculatorServices, ScientificCalculatorServices>();


builder.Services.AddScoped<IBasicCalculationProcess, BasicCalculationProcess>();
builder.Services.AddScoped<IScientificCalculationProcess, ScientificCalculationProcess>();

builder.Services.AddControllers();


builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "C# Refresher API v1");
        options.RoutePrefix = string.Empty;  // ← Swagger at root path
    });
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FactorialCalculator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllerWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapGet("/factorial/{number}", (HttpContext context, int number) => 
{
    var calculator = new FactorialService(); 
    long result = calculator.Calculate(number);;
   
    return $"The Factorial of {number} is: {result}";
});

app.Run();

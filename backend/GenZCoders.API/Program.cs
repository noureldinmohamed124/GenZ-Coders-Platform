using GenZCoders.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// 1. DbContext
builder.Services.AddDbContext<GenZDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AspTest")));


// 2. Repositories


// 3. Services


// 4. Use Cases


// 5. JWT Configurations



// force lowercase URLs
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
});



// When converting enums to/from JSON → use names instead of numbers
builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters
            .Add(new JsonStringEnumConverter());
    });




// Swagger (optional)
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




/*
 
    Install-Package Microsoft.EntityFrameworkCore -Version 8.0.20 (Infrastructure)
    Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.20 (Infrastructure)
    Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.20 (Infrastructure)
 
    Install-Package Microsoft.EntityFrameworkCore -Version 8.0.20 ()

    Install-Package FluentValidation -Version 12.1.0 (Application)
 
*/
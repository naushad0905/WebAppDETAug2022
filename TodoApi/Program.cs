using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoApi.Data;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodoApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TodoApiContext") ?? throw new InvalidOperationException("Connection string 'TodoApiContext' not found.")));


// Add services to the container.



builder.Services.AddControllers().AddOData(options => options.Select().Filter());
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

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();

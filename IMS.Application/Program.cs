using IMS.Domain.Entities;
using IMS.Domain.Entities.Dependencies;
using IMS.Infrastructure;
using IMS.Infrastructure.Interfaces;
using IMS.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<GlassesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
builder.Services.AddScoped<IRepository<Glasses>, PersistGlasses>();
builder.Services.AddScoped<IRepository<GlassesLensType>, PersistLensTypes>();
builder.Services.AddScoped<IRepository<GlassesColor>, PersistColors>();
builder.Services.AddScoped<IRepository<GlassesSize>, PersistSizes>();

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
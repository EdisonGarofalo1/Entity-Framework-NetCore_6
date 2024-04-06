using EntityFrameworkNetCore_6.Data;
using EntityFrameworkNetCore_6.Repositories.CategoriaRepository;
using EntityFrameworkNetCore_6.Repositories.ProductoRepository;
using EntityFrameworkNetCore_6.Services.CategoriaService;
using EntityFrameworkNetCore_6.Services.ProductoService;
using System.Text.Json.Serialization;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

  //  .AddJsonOptions(opciones =>
  //opciones.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
;


//.AddJsonOptions(opciones =>
//  opciones.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//.AddNewtonsoftJson(options =>
// {
//     options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
//     options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
//     // Agrega más configuraciones según sea necesario
// });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IProductoService, ProductoService>();

builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();



builder.Services.AddDbContext<ApplicationDbContext>(opciones =>
    opciones.UseSqlServer("name=Connection"));


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

using Ecommerce.Produto.Application.Services;
using Ecommerce.Produto.Data.AppData;
using Ecommerce.Produto.Data.Repositories;
using Ecommerce.Produto.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApplicationContext>(options => {
    options.UseOracle(builder.Configuration["ConnectionStrings:Oracle"]);
});

builder.Services.AddTransient<IBrinquedoRepository, BrinquedoRepository>();
builder.Services.AddTransient<IBrinquedoApplicationService, BrinquedoApplicationService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {

    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

using Gorevcim.Repository.AppDbContext;
using Gorevcim.Repository.Repositories.UnitOfWorks;
using Gorevcim.Core.Repositories;
using Gorevcim.Core.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Gorevcim.Core.Services;
using Gorevcim.Repository.Repositories;
using Gorevcim.Services.Services;
using Gorevcim.Services.Mapping;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//**************SONRADAN EKELENEN KODLAR BAÞLANGIÇ*****************///

builder.Services.AddScoped<IGenericUnitOfWork,UnitOfWork>();

builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));

builder.Services.AddScoped(typeof(IGenericService<>),typeof(GenericService<>));

builder.Services.AddAutoMapper(typeof(MapProfiles));


builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
        
    });
});

//**************SONRADAN EKELENEN KODLAR BÝTÝÞ*****************///


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

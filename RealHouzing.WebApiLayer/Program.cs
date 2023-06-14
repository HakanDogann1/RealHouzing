using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.BusinessLayer.Concrete;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLayer.EntityFramework;
using RealHouzing.DataAccessLAyer.Abstract;
using RealHouzing.DataAccessLAyer.Concrete;
using RealHouzing.DataAccessLAyer.EntityFramework;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService,CategoryManager>();

builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IHeaderDal, EfHeaderDal>();
builder.Services.AddScoped<IHeaderService,HeaderManager>();

builder.Services.AddScoped<IPropertyDal, EfPropertyDal>();
builder.Services.AddScoped<IPropertyService, PropertyManager>();

builder.Services.AddScoped<IProperty2Dal, EfProperty2Dal>();
builder.Services.AddScoped<IProperty2Service, Property2Manager>();

builder.Services.AddScoped<IProperty3Dal, EfProperty3Dal>();
builder.Services.AddScoped<IProperty3Service, Property3Manager>();

builder.Services.AddScoped<IAboutService1Dal, EfAboutService1Dal>();
builder.Services.AddScoped<IAboutService1Service, AboutService1Manager>();

builder.Services.AddScoped<ITeamDal, EfTeamDal>();
builder.Services.AddScoped<ITeamService, TeamManager>();

builder.Services.AddScoped<IContactChannelDal, EfContactChannelDal>();
builder.Services.AddScoped<IContactChannelService, ContactChannelManager>();


builder.Services.AddScoped<IContactMapDal, EfContactMapDal>();
builder.Services.AddScoped<IContactMapService, ContactMapManager>();

builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IAboutService, AboutManager>();

builder.Services.AddScoped<IAboutHeaderDal, EfAboutHeaderDal>();
builder.Services.AddScoped<IAboutHeaderService, AboutHeaderManager>();

builder.Services.AddScoped<IAboutQuestionHeaderDal, EfAboutQuestionHeaderDal>();
builder.Services.AddScoped<IAboutQuestionHeaderService, AboutQuestionHeaderManager>();

builder.Services.AddScoped<IAboutQuestionDal,EfAboutQuestionDal>();
builder.Services.AddScoped<IAboutQuestionService,AboutQuestionManager>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllersWithViews()
    .AddJsonOptions(opt=>opt.JsonSerializerOptions.ReferenceHandler=ReferenceHandler.IgnoreCycles);
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
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();

using Casgem_BusinessLayer.Abstract;
using Casgem_BusinessLayer.Concrete;
using Casgem_DataAccessLayer.Abstract;
using Casgem_DataAccessLayer.Concrete.Context;
using Casgem_DataAccessLayer.Concrete.EntityFramework;
using Casgem_EntityLayer.Entities.Concrete;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddDbContext<KariyerNetDbContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<KariyerNetDbContext>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddAuthentication();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICompanyDal, EfCompanyDal>();
builder.Services.AddScoped<ICurriculumVitaeDal, EfCurriculumVitaeDal>();
builder.Services.AddScoped<IDegreeDal, EfDegreeDal>();
builder.Services.AddScoped<IEducationInformationDal, EfEducationInformationDal>();
builder.Services.AddScoped<IEmployerDal, EfEmployerDal>();
builder.Services.AddScoped<IEmployerJobAdvertisementSearchHistoryDal, EfEmployerJobAdvertisementSearchHistoryDal>();
builder.Services.AddScoped<IJobAdvertisementDal, EfJobAdvertisementDal>();
builder.Services.AddScoped<IJobApplicationDal, EfJobApplicationDal>();
builder.Services.AddScoped<IJobSeekerDal, EfJobSeekerDal>();
builder.Services.AddScoped<IJobSeekerJobAdvertisementSearchHistoryDal, EfJobSeekerJobAdvertisementSearchHistoryDal>();
builder.Services.AddScoped<IWorkExperienceDal, EfWorkExperienceDal>();

builder.Services.AddScoped<ICompanyService, CompanyManager>();
builder.Services.AddScoped<ICurriculumVitaeService, CurriculumVitaeManager>();
builder.Services.AddScoped<IDegreeService, DegreeManager>();
builder.Services.AddScoped<IEducationInformationService, EducationInformationManager>();
builder.Services.AddScoped<IEmployerService, EmployerManager>();
builder.Services.AddScoped<IEmployerJobAdvertisementSearchHistoryService, EmployerJobAdvertisementSearchHistoryManager>();
builder.Services.AddScoped<IJobAdvertisementService, JobAdvertisementManager>();
builder.Services.AddScoped<IJobApplicationService, JobApplicationManager>();
builder.Services.AddScoped<IJobSeekerService, JobSeekerManager>();
builder.Services.AddScoped<IJobSeekerJobAdvertisementSearchHistoryService, JobSeekerJobAdvertisementSearchHistoryManager>();
builder.Services.AddScoped<IWorkExperienceService, WorkExperienceManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseSession();

app.MapControllers();

app.Run();

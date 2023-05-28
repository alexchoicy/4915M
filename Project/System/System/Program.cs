using System.Text;
using Microsoft.EntityFrameworkCore;
using Server.Model;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Server.Helper;
using Server.Helper.HttpError;
using Server.Model.Dto;
using Server.Services;
using System.Configuration;
using Server.Helper.CornJob;
using Swashbuckle.AspNetCore.Filters;
using Quartz.Impl;
using Quartz;
using Quartz.Spi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(
    options => options.UseMySql
    (builder.Configuration.GetConnectionString("conDB"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("conDB"))));
// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});
builder.Services.AddControllers();
builder.Services.AddScoped<AutoMapper.Mapper>();
//adding Services to the system
builder.Services.AddAutoMapper(typeof(Program));
{
    var services = builder.Services;
    services.AddScoped<ILoginServices, LoginServices>();
    services.AddScoped<IUserServices, UserServices>();
    services.AddScoped<ITestServices, TestServices>();
    services.AddScoped<IItemServices, ItemServices>();
    services.AddScoped<IOrderServices, OrderServices>();
    services.AddScoped<ICategoryServices,CategoryServices>();
}
builder.Services.AddScoped<JwtToken>();

builder.Logging.AddConsole();


Console.WriteLine(builder.Configuration["JWT:KEY"]);
//Setup TokenValidation
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            //ValidateLifetime is true by default
            //ValidateLifetime = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:KEY"])),
            ValidateIssuer = false,
            ValidateAudience = false
        };

    });
// builder.Services.AddMvc(options =>
// {
//     options.Filters.Add(new AuthFilter());
// });
//builder.Services.AddMvc(options =>
//    options.Filters.Add(new AuthorizeFilter())
//);



//setup CornJob
{
    var services = builder.Services;
    //services.AddScoped<MappingJob>();
    //services.AddSingleton<IJobFactory, QuartzJobFactory>();
    //services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
    services.AddQuartz(q =>
    {
        q.UseMicrosoftDependencyInjectionJobFactory();

        var jobKey = new JobKey("MappingJob");
        q.AddJob<MappingJob>(opts => opts.WithIdentity(jobKey));
        q.AddTrigger(opts => opts
            .ForJob(jobKey)
            //.WithCronSchedule("0 9,12,18 * * *")); // Schedule the job to run at 9 AM, 12 PM, and 6 PM
            .WithCronSchedule("0 43 21 ? * *"));

    });

    // Get the scheduler factory
    var schedulerFactory = services.BuildServiceProvider().GetService<ISchedulerFactory>();

    // Start the scheduler and set up the job
    var scheduler = await schedulerFactory.GetScheduler();
    await scheduler.Start();

    // Get the mapping job's trigger
    var jobTrigger = await scheduler.GetTrigger(new TriggerKey("MappingJob"));

    if (jobTrigger != null)
    {
        // Job and trigger are set up successfully
        Console.WriteLine("Mapping job is scheduled and ready to run.");
    }
    else
    {
        // Failed to set up job and trigger
        Console.WriteLine("Failed to set up mapping job.");
    }
}



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(settings =>
{
    settings.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        In = ParameterLocation.Header,
        Description = "JWT"
    });
    settings.OperationFilter<SecurityRequirementsOperationFilter>();
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Run();

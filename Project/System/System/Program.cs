using System.Text;
using Microsoft.EntityFrameworkCore;
using Server.Model;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Server.Helper;
using Server.Model.Dto;
using Server.Services;

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
builder.Services.AddAutoMapper(typeof(LoginMap));
builder.Services.AddScoped<ILoginServices, LoginServices>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<ITestServices, TestServices>();
builder.Services.AddScoped<JwtToken>();

//Setup TokenValidation
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            //ValidateLifetime is true by default
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:KEY"])),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
builder.Services.AddMvc(options =>
{
    options.Filters.Add(new AuthorizeFilter());
});

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

using Identity.Application.Middlewares;
using Microsoft.OpenApi.Models;

using Common.Application;
using Common.Infrastructure;

using Identity.Application.Middlewares;
using Identity.Application;
using Identity.Infrastructure;

using Administration.Application;
using Administration.Infrastructure;
using Inquiry.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//***************AddApplication**************//

builder.Services.AddCommonApplication();
builder.Services.AddIdentityApplication();
builder.Services.AddInquiryApplication();
builder.Services.AddAdminstrationApplication();


//***************AddPersistence**************//
builder.Services.AddCommonPersistence(builder.Configuration);
builder.Services.AddIdentityPersistence(builder.Configuration);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer {Token}."
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] {}
                }
            });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

// global cors policy
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

// custom jwt auth middleware
app.UseMiddleware<JwtMiddleware>();
app.UseHttpsRedirection();

// app.UseAuthentication();
// app.UseAuthorization();

app.MapControllers();

app.Run();


using Identity.Application;
using Identity.Infrastructure;

using Identity.API;

using Common.Application.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//***************AddApplication**************//
builder.Services.AddIdentityApplication();


//***************AddPersistence**************//
builder.Services.AddIdentityPersistence(builder.Configuration);

builder.Services.AddIdentityAPIServices();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

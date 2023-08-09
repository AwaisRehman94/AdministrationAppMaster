
using Inquiry.Application;
using Inquiry.Infrastructure;
using GlobalCommon.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//***************AddApplication**************//

builder.Services.AddInquiryApplication();

//***************AddPersistence**************//
builder.Services.AddGlobalCommonPersistence(builder.Configuration);
builder.Services.AddPersistence(builder.Configuration);

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

// app.UseAuthentication();
// app.UseAuthorization();

app.MapControllers();

app.Run();

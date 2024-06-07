using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
/*
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
*/
app.UseSwagger();
app.UseSwaggerUI();

// Redirect in production HTTP requests to HTTPS:
/*
if (app.Environment.IsProduction())
{
    app.UseHttpsRedirection();
}
*/

app.UseAuthorization();

app.MapControllers();

app.MapRazorPages();

app.Logger.LogInformation("IsDevelopment={IsDevelopment}; IsProduction={IsProduction}; IsStaging={IsStaging}; EnvironmentName={EnvironmentName}; DebuggerIsAttached={DebuggerIsAttached};"
    , [
        app.Environment.IsDevelopment(),
        app.Environment.IsProduction(),
        app.Environment.IsStaging(),
        app.Environment.EnvironmentName,
        Debugger.IsAttached
      ]
    );

// Add what "/" should return. 
// Add app.MapGet("/", () => "Hello World!");

app.Run();

// DEBUG URL:
// http://localhost/swagger/index.html
// http://localhost/swagger/v1/swagger.json

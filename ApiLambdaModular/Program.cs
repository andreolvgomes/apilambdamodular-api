using FastEndpoints.Swagger;
using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);

// ❌ ANTES (Para REST API):
//builder.Services.AddAWSLambdaHosting(LambdaEventSource.RestApi);

//  AGORA (Para HTTP API):
builder.Services.AddAWSLambdaHosting(LambdaEventSource.HttpApi);

builder.Services.AddControllers();
builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

//https://localhost:????/swagger
app.UseSwaggerGen();

app.MapGet("/", context =>
{
    context.Response.Redirect("/swagger");
    return Task.CompletedTask;
});

//app.UseAuthorization();
//app.MapControllers();

app.UseFastEndpoints(c =>
{
    c.Endpoints.Configurator = ep =>
    {
        ep.AllowAnonymous();
    };
});

app.Run();


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddHealthChecks();

WebApplication app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapHealthChecks("/health");

app.MapGet("/", () => "Design Pattern API is running.");


app.Run();
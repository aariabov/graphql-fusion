var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddControllers();
builder.Services.AddOpenApi(); // Включает генерацию openapi/v1.json

var app = builder.Build();

app.MapDefaultEndpoints();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); // Публикует схему по адресу http://localhost:5003/openapi/v1.json
}

app.UseAuthorization();
app.MapControllers();

app.Run();
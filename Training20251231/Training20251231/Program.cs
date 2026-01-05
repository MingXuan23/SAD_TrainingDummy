var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(x => x.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.AddSwaggerGen();
builder.WebHost.UseUrls("http://0.0.0.0:9000");

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

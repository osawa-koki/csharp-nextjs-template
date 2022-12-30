var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.UseDefaultFiles();
app.UseStaticFiles();

var api = app.MapGroup("/api");
{
  api.MapGet("/{name}", (string name) => $"Hello {name}! I am a GET man.");
  api.MapPost("/{name}", (string name) => $"Hello {name}! I am a POST man.");
  api.MapPut("/{name}", (string name) => $"Hello {name}! I am a POST man.");
  api.MapDelete("/{name}", (string name) => $"Hello {name}! I am a DELETE man.");
}

app.UseRouting();

app.Run("http://+:8080");

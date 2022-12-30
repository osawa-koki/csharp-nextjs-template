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

// SSG(Nextjs)のリロード用
string[] pages = new string[] {
  "index",
  "about",
};
app.MapGet($"/", () => Results.Text(File.ReadAllText($"./wwwroot/index.html"), "text/html"));
foreach (var page in pages)
{
  app.MapGet($"/{page}", () => Results.Text(File.ReadAllText($"./wwwroot/{page}.html"), "text/html"));
}

var api = app.MapGroup("/api");
{
  api.MapGet("/{name}", (string name) => $"Hello {name}! I am a GET man.");
  api.MapPost("/{name}", (string name) => $"Hello {name}! I am a POST man.");
  api.MapPut("/{name}", (string name) => $"Hello {name}! I am a POST man.");
  api.MapDelete("/{name}", (string name) => $"Hello {name}! I am a DELETE man.");
}

app.Run("http://+:8080");

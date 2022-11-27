var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

record Metas(int Id, string? Nome, bool IsConcluida);

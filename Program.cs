using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("MetasDB"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/metas", async (AppDbContext db, Meta meta) =>
{
    db.Metas.Add(meta);
    await db.SaveChangesAsync();
    return Results.Created($"/metas/{meta.Id}", meta);
});

app.Run();

record Meta(int Id, string? Nome, bool IsConcluida);

class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Meta> Metas => Set<Meta>();
}
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("MetasDB"));

var app = builder.Build();

app.MapGet("/metas", async (AppDbContext db) =>
    await db.Metas.AsNoTracking().ToListAsync());

app.MapGet("/metas/{id}", async (AppDbContext db, int id) =>
    await db.Metas.FindAsync(id)
        is Meta meta
            ? Results.Ok(meta)
            : Results.NotFound("Meta não encontrada."));

app.MapGet("/metas/concluidas", async (AppDbContext db) =>
    await db.Metas.Where(opt => opt.IsConcluida == true).ToListAsync());

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
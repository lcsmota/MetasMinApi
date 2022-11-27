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

app.MapPut("/metas/{id}", async (AppDbContext db, int id, Meta inputMeta) =>
{
    var meta = await db.Metas.FindAsync(id);
    if (meta is null) return Results.NotFound("Meta não encontrada.");

    meta.Nome = inputMeta.Nome;
    meta.IsConcluida = inputMeta.IsConcluida;

    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("metas/{id}", async (AppDbContext db, int id) =>
{
    if (await db.Metas.FindAsync(id) is Meta meta)
    {
        db.Metas.Remove(meta);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }

    return Results.NotFound("Meta não encontrada.");
});

app.Run();

class Meta
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public bool IsConcluida { get; set; }
}

class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Meta> Metas => Set<Meta>();
}
using Microsoft.EntityFrameworkCore;
using WebApplication1_Prosjekt1.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseDefaultFiles();
app.UseStaticFiles();
app.Run();

builder.Services.AddControllers();
builder.Services.AddDbContext<PasientContext>(x => x.UseSqlite("Data source=Pasient.db"));

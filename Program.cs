using htmx.net.Components;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents();

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/history", (HttpContext context) =>
        {
            return new RazorComponentResult<ListItems>();
        });

app.MapGet("/toolbar", (HttpContext context) =>
        {
            return new RazorComponentResult<Toolbar>();
        });

app.Run();

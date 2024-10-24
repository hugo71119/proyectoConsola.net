var builder = ProyectoConsola.CreateBuilder(args);
builder.Services.AddRazorPages(); // Add

var app = builder.Build();
// edit app.MapGet("/", () => "Hello World!");
app.MapRazorPages(); 
app.Run();
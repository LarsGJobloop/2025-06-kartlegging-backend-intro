var builder = WebApplication.CreateBuilder();
var app = builder.Build();

// Enable serving of HTML, CSS, JS, ++
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/hello", () => {
    return "Hello World";
});

app.MapGet("/bye", () => {
    return "Goodbye!";
});

app.Run();

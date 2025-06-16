var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.MapGet("/hello", () => {
    return "Hello World";
});

app.MapGet("/bye", () => {
    return "Goodbye!";
});

app.Run();

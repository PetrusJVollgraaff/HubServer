using HubServer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("https://localhost:7265").AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();
app.UseCors();

//app.MapGet("/", () => "Hello World!");
app.MapHub<ChatHub>("/chathub");

app.Run();

using Connect4API.Data;
using Microsoft.EntityFrameworkCore;
 
var builder = WebApplication.CreateBuilder(args);
 
const string CorsPolicy = "FrontendPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(CorsPolicy, policy =>
    {
        policy
            .WithOrigins(
                "http://localhost:3000",  // CRA
                "http://localhost:5173"   // Vite
            )
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials(); // only if you send cookies/auth headers
    });
});
 
// Add services to the container.
builder.Services.AddDbContext<Connect4Context>(options =>
    options.UseSqlite("Data Source=Data/connect4.db"));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
var app = builder.Build();
 
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
 
app.UseHttpsRedirection();
 
app.MapGet("/", () => Results.Redirect("/swagger/index.html"));
app.UseCors(CorsPolicy);
app.UseAuthorization();
 
app.MapControllers();
 
app.Run();
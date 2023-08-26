using Infinity.Server.Data;
using Infinity.Server.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
// Add DB Connection
builder.Services.AddDbContext<InfinityDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AppSqlServerDBContext")));
// First, add the dbContext
builder.Services.AddTransient<InfinityDbContext, InfinityDbContext>();
// Next, add an EFGenericRepository for each model you want a controller for
builder.Services.AddTransient<EFGenericRepository<Category, InfinityDbContext>>();
builder.Services.AddTransient<EFGenericRepository<CheatSheet, InfinityDbContext>>();
builder.Services.AddTransient<EFGenericRepository<Course, InfinityDbContext>>();
builder.Services.AddTransient<EFGenericRepository<Exercise, InfinityDbContext>>();
builder.Services.AddTransient<EFGenericRepository<DetailNote, InfinityDbContext>>();
builder.Services.AddTransient<EFGenericRepository<Solution, InfinityDbContext>>();
builder.Services.AddTransient<EFGenericRepository<Topic, InfinityDbContext>>();
builder.Services.AddTransient<EFGenericRepository<User, InfinityDbContext>>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
// Allow CORS to Accept Request from  localhost
app.UseCors(options =>
           options
           //.WithOrigins("http:\//localhost:3000")
           .WithOrigins()
           .AllowAnyMethod()
           .AllowAnyHeader());

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

using BikerNetApi.Data;
using BikerNetApi.Repository;
using BikerNetApi.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Creates controllers;
builder.Services.AddControllers();
// Injects Service intro container
builder.Services.AddScoped<IFeedPostService, FeedPostService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
// Injects Repos into services
builder.Services.AddScoped<IFeedPostRepository, FeedPostRepository>();
builder.Services.AddScoped<IUserRepository,UserRepository>();

// Used by Entity, Connection to DB
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();

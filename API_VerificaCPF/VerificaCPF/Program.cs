var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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


/*
 // Configure the app
builder.Host.ConfigureWebHostDefaults(webBuilder =>
{
    var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
    var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")??"Development";

    if(environment == "Development")
    {
        webBuilder.UseStartup<StartupBase>();
    }
    else
    {
        var url = $"http://0.0.0.0:{port}";
        webBuilder.UseStartup<StartupBase>().UseUrls(url);
    }
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

 
 
 */

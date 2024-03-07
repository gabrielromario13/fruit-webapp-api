var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

 // Add IHttpClientFactory to the container and set the name of the factory
 // to "FruitAPI". The base address for API requests is also set.
 builder.Services.AddHttpClient("FruitAPI", httpClient =>
 {
     httpClient.BaseAddress = new Uri("http://localhost:5050/fruitlist/");
 });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

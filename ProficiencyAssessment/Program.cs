var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors("ReactPolicy");

//This maps the default route and is linked to react via ClientApp/src/setupProxy.js
app.MapDefaultControllerRoute();

app.MapFallbackToFile("index.html");

app.Run();
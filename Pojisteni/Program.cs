using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pojisteni.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
	.AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Users}/{action=Index}/{id?}");

// Vytvoøení role administrátora

// using (var scope = app.Services.CreateScope())
// {
// RoleManager<IdentityRole> spravceRoli = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
// UserManager<IdentityUser> spravceUzivatelu = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

// spravceRoli.CreateAsync(new IdentityRole("admin")).Wait();
// IdentityUser uzivatel = spravceUzivatelu.FindByEmailAsync("admin@pojisteni.cz").Result;
// spravceUzivatelu.AddToRoleAsync(uzivatel, "admin").Wait();
// }

// Pokud bychom chtìli v budoucnu i dalšího administrátora,
// staèí odkomentovat a upravit jen èást kódu s jeho emailem a pøiøazením,
// role "admin" je již vytvoøená.


app.Run();
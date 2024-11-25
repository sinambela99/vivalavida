using HelloWorldApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Menambahkan DbContext ke dalam container DI (Dependency Injection)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Menambahkan layanan untuk controller
builder.Services.AddControllers();

var app = builder.Build();

// Menambahkan endpoint untuk API
app.MapControllers();

// Menjalankan aplikasi
app.Run();

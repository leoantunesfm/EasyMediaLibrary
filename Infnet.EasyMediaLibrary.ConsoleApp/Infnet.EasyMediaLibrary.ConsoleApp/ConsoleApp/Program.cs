using Infnet.EasyMediaLibrary.ConsoleApp.Application;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.Repositories;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.Services;
using Infnet.EasyMediaLibrary.ConsoleApp.Infrastructure.Data;
using Infnet.EasyMediaLibrary.ConsoleApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

// Configurar a injeção de dependência
var services = new ServiceCollection();

// Registrar o DbContext
services.AddDbContext<MediaLibraryDbContext>(options =>
    options.UseSqlite("Data Source=mediaLibrary.db")
);

// Registrar repositórios e serviços
services.AddScoped<IMidiaRepository, MidiaRepositorySqlite>();
services.AddScoped<BuscaAvancadaMidiaService>();
services.AddScoped<MediaLibraryApp>();

// Construir o provedor de serviços
var serviceProvider = services.BuildServiceProvider();

// Aplicar migrações
using (var scope = serviceProvider.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<MediaLibraryDbContext>();
    context.Database.Migrate(); // Cria o banco e aplica migrações
}

// Resolver a aplicação e executar
var mediaLibraryApp = serviceProvider.GetRequiredService<MediaLibraryApp>();
mediaLibraryApp.Run();
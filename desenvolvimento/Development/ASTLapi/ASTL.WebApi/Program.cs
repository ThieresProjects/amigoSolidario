using ASTL.Application.Services;
using ASTL.Data.Context;
using ASTL.Data.Repositories;
using ASTL.Domain.Interfaces.Repositories;
using ASTL.Domain.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICampanhaService, CampanhaService>();
builder.Services.AddScoped<ICampanhaGrupoService, CampanhaGrupoService>();
builder.Services.AddScoped<ICampanhaScoreService, CampanhaScoreService>();
builder.Services.AddScoped<IUsuarioCampanhaService, UsuarioCampanhaService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<IPessoaService, PessoaService>();
builder.Services.AddScoped<IContaService, ContaService>();

builder.Services.AddScoped<ICampanhaRepository, CampanhaRepository>();
builder.Services.AddScoped<ICampanhaGrupoRepository, CampanhaGrupoRepository>();
builder.Services.AddScoped<ICampanhaScoreRepository, CampanhaScoreRepository>();
builder.Services.AddScoped<IUsuarioCampanhaRepository, UsuarioCampanhaRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IPessoaRepository, PessoaRepository>();
builder.Services.AddScoped<IContaRepository, ContaRepository>();

IConfigurationRoot configuration;

//if (builder.Environment.IsEnvironment("External"))
//{
//    configuration = new ConfigurationBuilder()
//        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//        .AddJsonFile($"appsettings.Local.json")
//        .Build();

//}else{
//    configuration = new ConfigurationBuilder()
//        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//        .AddJsonFile($"appsettings.External.json")
//        .Build();
//}

//builder.Services.AddDbContext<SqlSContext>(options =>
//    options.UseSqlServer(configuration.GetConnectionString("BANDERA"))
//);

var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

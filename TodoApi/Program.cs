using MyApi.Controllers;
using MyApi.Data;

var builder = WebApplication.CreateBuilder(args);

#region Estrutura
builder.Services.AddDbContext<AppDBContext>();
builder.Services.AddControllers();
#endregion 

#region Ambiente
var app = builder.Build();
app.MapControllers();
#endregion 

app.Run();
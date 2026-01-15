var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
// add services here
var app = builder.Build();
// map endpoints here
app.Run();
using IG.MusicStore.Identidade.API.Configuration;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddApiConfiguration();
builder.Services.AddSwaggerConfiguration();


//pipeline
var app = builder.Build();
app.UseSwaggerConfiguration();
app.UseApiConfiguration();

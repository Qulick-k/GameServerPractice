using Newtonsoft.Json.Serialization;
using Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(o =>
{
    o.SerializerSettings.ContractResolver = new DefaultContractResolver(); //make letter case sensitive
});

//Learn more about configuruing Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddRazorPages();

builder.Services.AddScoped<IPlayerServices, PlayerServices>();

var app = builder.Build();

//不需要swagger了
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//不需要swagger了
//app.UseSwagger();
//app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();  //記得加上MapControllers，否則swagger會回報404

app.MapRazorPages();

app.Run();

using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? "DataSource=Data\\app.db";

//builder.
//builder.Services.AddSqlite<PremiumRolDbContext>

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


/// <summary>
/// adding logging
/// </summary>
var loggerFactory = LoggerFactory.Create(builder =>
{
    builder.AddConsole();

});

ILogger logger = loggerFactory.CreateLogger<ILogger>();






/// <summary>
///  SQL Lite Support
/// </summary>
builder.Services.AddSqlite<PremiumRolDbContext>(connectionString); //DBContext
builder.Services.AddScoped<IPremiumRolRepository, PremiumRolRepository>();//Repository
builder.Services.AddScoped<IPlanRepository, PlanRepository>();//Repository
builder.Services.AddScoped<IStateRepository, StateRepository>();//Repository
builder.Services.AddScoped<IPeriodRepository, PeriodRepository>();//Repository

/// <summary>
/// CORS
/// </summary>
var MyAllowSpecificOrigins = "_AllowSpecificOrigins";

/// <summary>
/// to configure the origin, go to the appsettings.json section
/// </summary>
var WebAddress = builder.Configuration.GetValue<string>("WebClientConfig:WebAddress");

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins(WebAddress)
                          .AllowAnyHeader()
                          .AllowAnyMethod()
                          .AllowCredentials();
                      });
});

//end

builder.Services.AddControllers();
var app = builder.Build();

//Add endpoints to the mapping
//app.UseRouting();



/*app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});*/

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
/// <summary>
/// Configure CORS
/// </summary>
app.UseCors(MyAllowSpecificOrigins);

/*
app.MapGet("/PlanList", async (PremiumRolDbContext db) => await db.Plans.ToListAsync());
app.MapGet("/PeriodList", async (PremiumRolDbContext db) => await db.Periods.ToListAsync());
/// <summary>
/// Select the state list, with an ascending order
/// </summary>
app.MapGet("/StateList", async (PremiumRolDbContext db) =>
{
    var select = from state in db.States
                 orderby state.StateName ascending
                 select new
                 {
                     state.StateId,
                     state.StateName
                 };
    return Results.Ok(await select.ToListAsync());
}
);*/


/// <summary>
/// Get the premium information
/// </summary>
/*app.MapPut("/Premium", async ([FromBody] PremiumQ q,
                               [FromServices] PremiumRolDbContext db) =>
{



}
);*/



app.Run();

using Task1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

List<Game> games = new List<Game>
{
 new Game{IdGame = 1, Name = "Tetris", Category = "головоломка", Price = 150},
 new Game{IdGame = 2, Name = "Flappy Bird", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
 new Game{IdGame = 3, Name = "Pac-man", Description = "игра про колобка", Category = "аркада", Price = 300},
 new Game{IdGame = 4, Name = "Arkanoid", Category = "аркада", Price = 400},
 new Game{IdGame = 5, Name = "Mario", Description = "игра про Марио", Category = "платформер", Price = 1000},
 new Game{IdGame = 6, Name = "Tetris2", Category = "головоломка", Price = 150},
 new Game{IdGame = 7, Name = "Flappy Bird2", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
 new Game{IdGame = 8, Name = "Pac-man2", Description = "игра про колобка", Category = "аркада", Price = 300},
 new Game{IdGame = 9, Name = "Arkanoid2", Category = "аркада", Price = 400},
 new Game{IdGame = 10, Name = "Mario2", Description = "игра про Марио", Category = "платформер", Price = 1000},
};

//app.MapGet("/games", () => games);
//app.MapGet("/games/{id:int}", (int id) => games.FirstOrDefault(x => x.IdGame == id));
//app.MapGet("/games", (string? category) =>
//{
//    var result = games.AsEnumerable();
//    if (category != null)
//        result = result.Where(x => x.Category.Equals(category, StringComparison.InvariantCultureIgnoreCase));
//    return result;
//});
app.MapGet("/games", (int? page, int? size) =>
{
    var result = games.AsEnumerable();
    if (page != null && page != null)
        return result.Skip(Convert.ToInt32(size) * (page ?? -1)).Take(Convert.ToInt32(size));
    return result;
});
app.MapDelete("/games/{id:int}", (int id) =>
{
    if (id >= games.Count && id < 1)
    {
        Results.NotFound(new { message = "not found!!!!!!!!!!" });
    }
    games.RemoveAll(x => x.IdGame == id);
    return Results.Json(games);
});



//app.MapGet("/summaries", (int? page, string? start) =>
//{
//    var result = summaries.AsEnumerable();
//    if(start!=null)
//        result=result.Where(x=>x.StartsWith(start));
//    int size = 3;
//    if (page != null)
//        return result.Skip(size * (page?? - 1)).Take(size);
//    return result;
//});
////app.MapGet("/summaries", () => summaries);

//app.MapGet("/summaries/{id:int}", (int id) => summaries[id]);

//app.MapDelete("/summaries/{id:int}", (int id) =>
//{
//    if (id >= summaries.Count)
//    {
//        Results.NotFound(new { message = "not found!!!!!!!!!!" });
//    }
//    summaries.RemoveAt(id);
//    return Results.Json(summaries);
//});

//app.MapGet("/weatherforecast", () =>
//{
//    var forecast = Enumerable.Range(1, 5).Select(index =>
//        new WeatherForecast
//        (
//            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//            Random.Shared.Next(-20, 55),
//            summaries[Random.Shared.Next(summaries.Length)]
//        ))
//        .ToArray();
//    return forecast;
//})
//.WithName("GetWeatherForecast")
//.WithOpenApi();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World 4");
app.MapGet("/user", () => new
{
    Name = "Aurelio Vulcao"
});
app.MapGet("/AddHeader", () => "repos");

app.MapPost("/saveproduct", (Product product) =>
{
    return product.Code + " - " + product.Name + " Foi cadastrado com sucesso";
});



app.Run();

public class Product
{
    public string Code { get; set; }
    public string Name { get; set; }
}
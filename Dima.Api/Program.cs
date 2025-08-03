var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// Endpoints -> URL para acesso
app.MapPost(
"/v1/transactions",
        () => "Hello World!");


app.Run();

//Request
public class Request
{
        public string Title { get; set; } =  String.Empty;

        public DateTime CreateAt { get; set; } = DateTime.Now;
        public int Type { get; set; }

        public decimal Amount { get; set; }

        public long CategoryId { get; set; }
        public string UserId { get; set; } = String.Empty;
}








// Request - Requisição
// GET, POST, PUT E DELETE
// obter, Criar, Atualizar, Excluir -Crud
// GET - (Não tem corpo)
// Requisição -> Cabeçalho e Corpo
// JSON - JavaScript Object Notation
// Binding -. vínculo transforma o Json em objeto c#
// Response (resposta da requisição) -> Status Code

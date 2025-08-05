using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddScoped<Handler>(); // incluido via chat gpt
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
        x.CustomSchemaIds(type => type.FullName);
});
builder.Services.AddTransient<Handler>(); // incluido via Balta


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Endpoints -> URL para acesso
app.MapPost(
"/v1/transactions",
        (Request request, Handler handler) 
                => handler.Handle(request))
    
        .WithName("Transactions: Create")
        .WithSummary("Create new Transaction")
        .Produces<Response>();


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

// Response
public class Response
{
        
        public long Id { get; set; }
        public string Title { get; set; } = String.Empty;
}

// Handler
public class Handler
{
        // Faz todo o processo de criação
        // Persiste no banco...
        public Response Handle(Request request)
        {
                return new Response
                {
                        Id = 4,
                        Title = request.Title

                };
        }
}






// Request - Requisição
// GET, POST, PUT E DELETE
// obter, Criar, Atualizar, Excluir -Crud
// GET - (Não tem corpo)
// Requisição -> Cabeçalho e Corpo
// JSON - JavaScript Object Notation
// Binding -. vínculo transforma o Json em objeto c#
// Response (resposta da requisição) -> Status Code

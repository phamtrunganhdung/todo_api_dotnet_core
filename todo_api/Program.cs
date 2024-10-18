using Microsoft.EntityFrameworkCore;
using todo_api;
using todo_api.todo;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo api");
        c.RoutePrefix = string.Empty;  
    });
}

app.MapGroup("/todoitems").MapTodoRoutes();

app.MapGet("/", () => "Hello World!");

app.Run();
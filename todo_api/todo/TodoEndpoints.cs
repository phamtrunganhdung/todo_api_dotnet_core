namespace todo_api.todo
{
    public static class TodoEndpoints
    {
        public static RouteGroupBuilder MapTodoRoutes(this RouteGroupBuilder group)
        {
            group.MapGet("/", TodoHandlers.GetAllTodos);
            group.MapGet("/complete", TodoHandlers.GetCompleteTodos);
            group.MapGet("/{id}", TodoHandlers.GetTodo);
            group.MapPost("/", TodoHandlers.CreateTodo);
            group.MapPut("/", TodoHandlers.UpdateTodo);
            group.MapDelete("/{id}", TodoHandlers.DeleteTodo);

            return group;
        }
    }
}

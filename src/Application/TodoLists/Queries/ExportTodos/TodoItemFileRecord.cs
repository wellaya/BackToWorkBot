using BackToWorkBot.Application.Common.Mappings;
using BackToWorkBot.Domain.Entities;

namespace BackToWorkBot.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}

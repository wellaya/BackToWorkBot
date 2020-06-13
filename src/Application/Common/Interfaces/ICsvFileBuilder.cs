using BackToWorkBot.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace BackToWorkBot.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}

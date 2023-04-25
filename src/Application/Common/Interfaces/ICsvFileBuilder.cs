using UploadPhoto.Application.TodoLists.Queries.ExportTodos;

namespace UploadPhoto.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}

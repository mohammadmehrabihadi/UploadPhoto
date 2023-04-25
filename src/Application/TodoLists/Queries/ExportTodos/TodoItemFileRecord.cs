using UploadPhoto.Application.Common.Mappings;
using UploadPhoto.Domain.Entities;

namespace UploadPhoto.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}

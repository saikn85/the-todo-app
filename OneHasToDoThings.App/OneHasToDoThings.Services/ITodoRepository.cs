﻿using OneHasToDoThings.Domain;

namespace OneHasToDoThings.AppCore
{
    public interface ITodoRepository : IDisposable
    {
        Task<ToDo> CreateAsync(ToDo todo);
        Task<bool> UpdateAsync(ToDo todo);
        Task<bool> DeleteAsync(ToDo todo);
        Task<IEnumerable<ToDo>> ReadAsync(TaskType? tType, DateTime? tCreated, string? tName, string? tDesc);
        Task<ToDo> ReadAsync(Guid id);
    }
}

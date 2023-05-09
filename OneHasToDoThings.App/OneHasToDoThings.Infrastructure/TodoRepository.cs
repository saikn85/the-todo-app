using Microsoft.Extensions.Configuration;
using OneHasToDoThings.AppCore;
using OneHasToDoThings.Domain;

namespace OneHasToDoThings.Infrastructure
{
    public class TodoRepository : ITodoRepository
    {
        #region Dependencies

        private readonly DAL _dataAccess;

#pragma warning disable CS8604 // Possible null reference argument.
        public TodoRepository(IConfiguration config) =>
            _dataAccess = new DAL(config.GetConnectionString("DefaultConnectionString"));
#pragma warning restore CS8604 // Possible null reference argument.

        #endregion

        public Task<ToDo> CreateAsync(ToDo todo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(ToDo todo)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ToDo>> ReadAsync(TaskType? tType, DateTime? tCreated, string? tName, string? tDesc)
        {
            throw new NotImplementedException();
        }

        public Task<ToDo> ReadAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(ToDo todo)
        {
            throw new NotImplementedException();
        }
    }
}

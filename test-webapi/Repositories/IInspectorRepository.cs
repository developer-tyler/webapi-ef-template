using test_webapi.Data.Entities;

namespace test_webapi.Repositories
{
    public interface IInspectorRepository
    {
        Task<IEnumerable<InspectorEntity>> GetAllAsync();
        Task<InspectorEntity?> GetByIdAsync(int id);
        Task<InspectorEntity> AddAsync(InspectorEntity inspector);
        Task UpdateAsync(InspectorEntity inspector);
        Task DeleteAsync(int id);
    }
}

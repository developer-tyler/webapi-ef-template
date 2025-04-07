using test_webapi.DTOs;

namespace test_webapi.Services
{
    public interface IInspectorService
    {
        Task<IEnumerable<InspectorDto>> GetAllInspectorsAsync();
        Task<InspectorDto?> GetInspectorByIdAsync(int id);
        Task<InspectorDto> CreateInspectorAsync(InspectorDto inspectorDto);
        Task<InspectorDto> UpdateInspectorAsync(int id, InspectorDto inspectorDto);
        Task DeleteInspectorAsync(int id);
    }
}

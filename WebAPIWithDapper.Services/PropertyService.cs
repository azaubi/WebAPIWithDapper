using AutoMapper;
using WebAPIWithDapper.Core.Dtos;
using WebAPIWithDapper.Data.Repos;

namespace WebAPIWithDapper.Services
{
    public interface IPropertyService
    {
        Task<List<PropertyDto>> Get();
    }

    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepo _propertyRepo;
        private readonly IMapper _mapper;

        public PropertyService(IPropertyRepo propertyRepo, IMapper mapper)
        {
            _propertyRepo = propertyRepo;
            _mapper = mapper;
        }

        public virtual async Task<List<PropertyDto>> Get()
           => _mapper.Map<List<PropertyDto>>(await _propertyRepo.Get());
    }
}
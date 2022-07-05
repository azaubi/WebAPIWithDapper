using AutoMapper;
using WebAPIWithDapper.Core.Dtos;
using WebAPIWithDapper.Data.Repos;

namespace WebAPIWithDapper.Services.Services
{
    public interface IResidentService
    {
        Task<List<ResidentDto>> Get();
    }

    public class ResidentService : IResidentService
    {
        private readonly IResidentRepo _propertyRepo;
        private readonly IMapper _mapper;

        public ResidentService(IResidentRepo propertyRepo, IMapper mapper)
        {
            _propertyRepo = propertyRepo;
            _mapper = mapper;
        }

        public virtual async Task<List<ResidentDto>> Get()
           => _mapper.Map<List<ResidentDto>>(await _propertyRepo.Get());
    }
}

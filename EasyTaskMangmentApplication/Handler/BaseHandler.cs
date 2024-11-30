using AutoMapper;
using EasyTaskMangmentDomain.Infra.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyTaskMangmentApplication.Handler
{
    public class BaseHandler<TRepository, TCreateRequest, TUpdateRequest, TResponse, TDTO>
        where TRepository : IBaseRepository<TDTO>
        where TDTO : class
    {
        protected readonly TRepository _repository;
        protected readonly IMapper _mapper;

        public BaseHandler(TRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<TResponse>> GetAllActive()
        {
            var entities = await _repository.GetAllActive();
            return _mapper.Map<List<TResponse>>(entities);
        }

        public async Task<int> Insert(TCreateRequest createRequest)
        {
            var dto = _mapper.Map<TDTO>(createRequest);
            return await _repository.Insert(dto);
        }

        public async Task<bool> Update(TUpdateRequest updateRequest)
        {
            var dto = _mapper.Map<TDTO>(updateRequest);
            return await _repository.Update(dto);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }
    }
}

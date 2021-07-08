using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Core.Interfaces;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class FlatService : IFlatService
    {
        private readonly IFlatRepository _flatRepository = null;
        private readonly IMapper _mapper;
        public FlatService(IFlatRepository flatRepository,IMapper mapper)
        {
            _flatRepository = flatRepository;
            _mapper = mapper;
        }

        public async Task<bool> Add(FlatViewModel entity)
        {
            var flat = _mapper.Map<Flat>(entity);
            int result = await _flatRepository.Add(flat);
            return result > 0;
        }

        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> Update(FlatViewModel entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FlatViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<FlatViewModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

       
    }
}

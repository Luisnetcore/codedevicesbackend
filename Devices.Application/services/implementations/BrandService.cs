using AutoMapper;
using Devices.Application.DTOs;
using Devices.Application.services.interfaces;
using Devices.Domain.Entities;
using Devices.Infraestructure.Data.Repository.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Application.services.implementations
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _repository;
        private readonly IMapper _mapper;
        public BrandService(IBrandRepository brandRepository, IMapper mapper) { 

            _repository = brandRepository;
            _mapper = mapper;

        }

        public async Task<BrandCreateDTO> CreateBrand(BrandCreateDTO brandCreateDTO)
        {
            var brandNew = _mapper.Map<Brand>(brandCreateDTO);
            await _repository.Add(brandNew);
            return brandCreateDTO;
        }

        public Task<List<BrandInformationDTO>> GetBrands()
        {
            throw new NotImplementedException();
        }
    }
 }

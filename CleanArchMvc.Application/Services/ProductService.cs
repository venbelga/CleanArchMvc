using AutoMapper;
using CleanArchMvc.Application.Dtos;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;

namespace CleanArchMvc.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Add(ProductDto productDto)
        {
            var productEntity = _mapper.Map<Product>(productDto);
            await _repository.CreateAsync(productEntity);
        }

        public async Task<ProductDto> GetById(int id)
        {
            var productEntity = await _repository.GetByIdAsync(id);
            return _mapper.Map<ProductDto>(productEntity);
        }

        public async Task<ProductDto> GetProductCategory(int? id)
        {
            var productEntity = await _repository.GetProductCategoryAsync(id);
            return _mapper.Map<ProductDto>(productEntity);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var productsEntity = await _repository.GetProductAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(productsEntity);
        }

        public async Task Remove(int? id)
        {
            var productEntity = _repository.GetByIdAsync(id).Result;
            await _repository.RemoveAsync(productEntity);
        }

        public async Task Update(ProductDto productDto)
        {
            var productEntity = _mapper.Map<Product>(productDto);
            await _repository.UpdateAsync(productEntity);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SmartShop.Domain.Interfaces;
using SmartShop.Domain.Queries;
namespace SmartShop.Domain.Queries.Categoria
{
    public class CategoryQuery : ICategoryQueries
    {
        private ICategoryRepository _categoryRepository;

        public CategoryQuery(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<CategoryViewModel> GerCategoryAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<CategoryViewModel> GetAll()
        {

            List<CategoryViewModel> lista = new List<CategoryViewModel>();
           var entities =  _categoryRepository.GetAll();

            foreach (var item in entities)
            {
                lista.Add(new CategoryViewModel()
                {
                    Id = item.Id,
                    Description = item.Description
              });
            }

            return lista;
        }
    }
}

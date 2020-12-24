

using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface  IPublicProductService
    {
       Task<PageResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();

    }
}

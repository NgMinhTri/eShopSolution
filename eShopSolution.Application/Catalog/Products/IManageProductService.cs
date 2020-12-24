
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Products;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productid);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewcount(int productid);       
        Task<PageResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        
        
    }
}

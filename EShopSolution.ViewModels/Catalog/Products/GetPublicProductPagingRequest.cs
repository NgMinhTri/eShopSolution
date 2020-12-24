
using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.Products
{
  public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}

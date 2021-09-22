using eShopSolution.Data.EF;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Languages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.Application.System.Languages
{
    public class LanguageService : ILanguageService
    {
        private readonly EShopDbContext _context;
        public LanguageService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            var language = await _context.Languages.Select(l => new LanguageVm()
            {
                Id = l.Id,
                Name = l.Name
            }).ToListAsync();
            return new ApiSuccessResult<List<LanguageVm>>(language);
        }
    }
}

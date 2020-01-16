using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Shqip.Models
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable,
            PaginationDTO pagination)
        {
            return queryable
                .Skip((pagination.Page - 1) * pagination.QuantityPerPage)
                .Take(pagination.QuantityPerPage);
        }

        public async static Task<T> FindAsync<T>(this IQueryable<T> queryable, int id)
            where T : IFjale
        {
            return await queryable.FirstOrDefaultAsync(i => i.Id == id);
        }
    }
}

using ApiInChains.EfCore;
using ApiInChains.Grammar;

namespace ApiInChains
{
    public class ApiInChains
    {
        public static IGetMany<T> FromMany<T>() where T : class
        {
            AppDbContext dbContext = new AppDbContext();
            IQueryable<T> query = dbContext.Set<T>().AsQueryable();
            return new UltimateQueryBuilderMany<T>(query);
        }
    }
}
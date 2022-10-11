using ApiInChains.Grammar;

namespace ApiInChains
{
    public class ApiInChains
    {
        public static IGetMany<T> FromMany<T>() where T : class
        {
            return new UltimateQueryBuilderMany<T>();
        }
    }
}
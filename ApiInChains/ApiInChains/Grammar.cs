namespace ApiInChains.Grammar
{
    public class UltimateQueryBuilderMany<T> : IGetMany<T>, IWhere<T>, IAndWhere<T>, IOrderBy<T>, IInclude<T>, IAndInclude<T>, IFetch<T> where T : class
    {
        public IWhere<T> GetMany()
        {
            return this;
        }

        public IAndWhere<T> Where()
        {
            return this;
        }

        public IAndWhere<T> AndWhere()
        {
            return this;
        }

        public IAndInclude<T> Include()
        {
            return this;
        }

        public IAndInclude<T> AndInclude()
        {
            return this;
        }

        public IFetch<T> OrderBy()
        {
            return this;
        }

        public IEnumerable<T> Fetch()
        {
            return new List<T>();
        }
    }

    public interface IGetMany<T> where T : class
    {
        IWhere<T> GetMany();
    }

    public interface IWhere<T> : IFetch<T>, IOrderBy<T>, IInclude<T> where T : class
    {
        IAndWhere<T> Where();
    }

    public interface IAndWhere<T> : IFetch<T>, IOrderBy<T>, IInclude<T> where T : class
    {
        IAndWhere<T> AndWhere();
    }

    public interface IInclude<T> : IFetch<T>, IOrderBy<T> where T : class
    {
        IAndInclude<T> Include();
    }

    public interface IAndInclude<T> : IFetch<T>, IOrderBy<T> where T : class
    {
        IAndInclude<T> AndInclude();
    }

    public interface IOrderBy<T> where T : class
    {
        IFetch<T> OrderBy();
    }

    public interface IFetch<T> where T : class
    {
        IEnumerable<T> Fetch();
    }
}
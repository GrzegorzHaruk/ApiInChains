using System.Linq.Expressions;

namespace ApiInChains.Grammar
{
    public class UltimateQueryBuilderMany<T> : IGetMany<T>, IWhere<T>, IAndWhere<T>, IOrderBy<T>, IInclude<T>, IAndInclude<T>, IFetch<T> where T : class
    {
        private IQueryable<T> _query;

        public UltimateQueryBuilderMany(IQueryable<T> query)
        {
            _query = query;
        }

        public IWhere<T> GetMany()
        {
            return this;
        }

        public IAndWhere<T> Where(Expression<Func<T, bool>> filter)
        {
            _query = _query.Where(filter);
            return this;
        }

        public IAndWhere<T> AndWhere(Expression<Func<T, bool>> filter)
        {
            _query = _query.Where(filter);
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
            return _query.ToList();
        }
    }

    public interface IGetMany<T> where T : class
    {
        IWhere<T> GetMany();
    }

    public interface IWhere<T> : IFetch<T>, IOrderBy<T>, IInclude<T> where T : class
    {
        IAndWhere<T> Where(Expression<Func<T, bool>> filter);
    }

    public interface IAndWhere<T> : IFetch<T>, IOrderBy<T>, IInclude<T> where T : class
    {
        IAndWhere<T> AndWhere(Expression<Func<T, bool>> filter);
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
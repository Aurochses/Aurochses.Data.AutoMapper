using System.Linq;
using AutoMapper.QueryableExtensions;

namespace Aurochses.Data.AutoMapper
{
    /// <summary>
    /// DataMapper class.
    /// </summary>
    /// <seealso cref="Aurochses.Data.IDataMapper" />
    public class DataMapper : IDataMapper
    {
        /// <summary>
        /// Method to map from a queryable using the provided mapping engine
        /// </summary>
        /// <typeparam name="TDestination">Destination type</typeparam>
        /// <param name="source">Queryable source</param>
        /// <returns>Expression to map into</returns>
        public IQueryable<TDestination> Map<TDestination>(IQueryable source)
        {
            return source.ProjectTo<TDestination>();
        }
    }
}
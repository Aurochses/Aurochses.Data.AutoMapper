﻿using System.Linq;
using AutoMapper;

namespace Aurochses.Data.AutoMapper
{
    /// <summary>
    /// DataMapper class.
    /// </summary>
    /// <seealso cref="Aurochses.Data.IDataMapper" />
    public class DataMapper : IDataMapper
    {
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataMapper"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        public DataMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Method to map from a queryable using the provided mapping engine
        /// </summary>
        /// <typeparam name="TDestination">Destination type</typeparam>
        /// <param name="source">Queryable source</param>
        /// <returns>Expression to map into</returns>
        public IQueryable<TDestination> Map<TDestination>(IQueryable source)
        {
            return _mapper.ProjectTo<TDestination>(source);
        }
    }
}
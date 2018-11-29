using Patterns.Specification;
using Showroom.Common;
using System;
using System.Linq.Expressions;

namespace Showroom.Specification
{
    class OldMovieSpecification : Specification<Movie>
    {
        public override Expression<Func<Movie, bool>> GetExpression()
        {
            return x => x.Year < 1970;
        }
    }
}

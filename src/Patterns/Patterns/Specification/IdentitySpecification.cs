using System;
using System.Linq.Expressions;

namespace Patterns.Specification
{
    internal sealed class IdentitySpecification<T> : Specification<T>
    {
        public override Expression<Func<T, bool>> GetExpression()
        {
            return x => true;
        }
    }



}

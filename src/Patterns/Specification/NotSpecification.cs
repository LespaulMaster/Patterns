using System;
using System.Linq.Expressions;

namespace Patterns.Specification
{
    internal sealed class NotSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _specification;

        public NotSpecification(Specification<T> specification)
        {
            _specification = specification;

        }
        public override Expression<Func<T, bool>> GetExpression()
        {
            var expression = _specification.GetExpression();

            var andExpression = Expression.Not(expression.Body);

            return Expression.Lambda<Func<T, bool>>(andExpression, expression.Parameters);
        }
    }
}

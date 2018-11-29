using System;
using System.Linq.Expressions;

namespace Patterns.Specification
{
    internal sealed class AndSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _left;
        private readonly Specification<T> _right;

        public AndSpecification(Specification<T> left, Specification<T> right)
        {
            _left = left;
            _right = right;
        }
        public override Expression<Func<T, bool>> GetExpression()
        {
            Expression<Func<T, bool>> leftExpression = _left.GetExpression();
            Expression<Func<T, bool>> rightExpression = _right.GetExpression();
            var invokedExpression = Expression.Invoke(rightExpression, leftExpression.Parameters);

            return Expression.Lambda<Func<T, bool>>(Expression.AndAlso(leftExpression.Body, invokedExpression), leftExpression.Parameters);

        }
    }



}

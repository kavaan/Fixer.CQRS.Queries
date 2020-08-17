using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.CQRS.Queries
{
    public interface IFilter<TResult, in TQuery> where TQuery : IQuery
    {
        IEnumerable<TResult> Filter(IEnumerable<TResult> values, TQuery query);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.CQRS.Queries
{
    //Marker
    public interface IQuery
    {
    }

    public interface IQuery<T> : IQuery
    {
    }
}

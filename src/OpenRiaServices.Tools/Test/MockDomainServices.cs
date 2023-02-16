using System;
using System.Collections.Generic;
using OpenRiaServices.Server;
using TestDomainServices.EFCore;

namespace OpenRiaServices.Tools.Test
{
    /// <summary>
    /// A generic <see cref="DomainService"/> used for unit testing.
    /// </summary>
    /// <typeparam name="T">The Type of entity to return in a Query method.</typeparam>
    [EnableClientAccess]
    public class GenericDomainService<T> : DomainService
    {
        [Query]
        public IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }
    }

    [EnableClientAccess]
    public class GenericDomainServiceEfCore<T> : Northwind_CUD
    {
        [Query]
        public IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }
    }
}

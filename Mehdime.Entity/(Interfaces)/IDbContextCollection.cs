/* 
 * Copyright (C) 2014 Mehdi El Gueddari
 * http://mehdi.me
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 */
using System;

#if NET45 || NET462
using System.Data.Entity;
#elif NETSTANDARD2
using Microsoft.EntityFrameworkCore;
#endif

namespace Mehdime.Entity
{
    /// <summary>
    /// Maintains a list of lazily-created DbContext instances.
    /// </summary>
    public interface IDbContextCollection : IDisposable
    {
        /// <summary>
        /// Get or create a DbContext instance of the specified type. 
        /// </summary>
		TDbContext Get<TDbContext>() where TDbContext : DbContext;
    }
}
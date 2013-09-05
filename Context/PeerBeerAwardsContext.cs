using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PeerBeerAwards.Models;

namespace PeerBeerAwards.Context
{
    public class PeerBeerAwardsContext : DbContext
    {
        public DbSet<Nominee> Nominees { get; set; }

        /// <summary>
        /// Set entity to the state modified
        /// </summary>
        /// <param name="entity">Entity which is modified</param>
        public void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Set entity to the state deleted
        /// </summary>
        /// <param name="entity">Entity to delete</param>
        public void Delete(object entity)
        {
            Entry(entity).State = EntityState.Deleted;
        }
    }
}

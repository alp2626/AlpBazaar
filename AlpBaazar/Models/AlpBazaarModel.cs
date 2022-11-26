using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AlpBaazar.Models
{
    public partial class AlpBazaarModel : DbContext
    {
        public AlpBazaarModel()
            : base("name=AlpBazaarModel")
        {
        }
        
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<ManagerType> ManagersTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

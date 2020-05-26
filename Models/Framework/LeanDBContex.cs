namespace Models.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LeanDBContex : DbContext
    {
        public LeanDBContex()
            : base("name=LeanDBContex")
        {
        }

        public virtual DbSet<useraccount> useraccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

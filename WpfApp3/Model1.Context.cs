//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Расчет_премииEntities : DbContext
    {
        private static Расчет_премииEntities _context;

        public static Расчет_премииEntities getContext()
        {
            if( _context == null)
            {
                return _context = new Расчет_премииEntities();
            }
            return _context;
        }
        public Расчет_премииEntities()
            : base("name=Расчет_премииEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Control_Employes> Control_Employes { get; set; }
        public virtual DbSet<Control_Tasks> Control_Tasks { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
    }
}

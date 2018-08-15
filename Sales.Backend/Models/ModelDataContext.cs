
namespace Sales.Backend.Models
{
    using Domain.Productos;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Sales.Common.Modelo.Productos> Productos { get; set; }
    }
}
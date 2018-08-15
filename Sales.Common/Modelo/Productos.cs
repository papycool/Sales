

namespace Sales.Common.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public Decimal Precio { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime PublicadoFec { get; set; }
    }
}

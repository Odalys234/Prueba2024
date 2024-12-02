using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OdalysEscobar2024.PruebaTecnica.EN
{
    public class Producto
    {
        [Key] 
        public int Id { get; set; }

        [Required] 
        [MaxLength(100)] 
        public string Nombre { get; set; }

        [Required] 
        [Column(TypeName = "decimal(10,2)")] 
        public decimal Precio { get; set; }

        [Required] 
        [ForeignKey("Categoria")] 
        public int IdCategoria { get; set; }


        public Categoria Categorias { get; set; }
    }
}

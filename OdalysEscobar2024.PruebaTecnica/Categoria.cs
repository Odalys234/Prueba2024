
using OdalysEscobar2024.PruebaTecnica.EN;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OdalysEscobar2024.PruebaTecnica
{
    public class Categoria
    {
        [Key] 
        public int Id { get; set; }

        [Required] 
        [MaxLength(100)] 
        [Column("NombreCategoria")]
        public string Nombre { get; set; }
        public Producto productos { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Filmes_Senai.Domains
{

    [Table("Genero")]
    public class Genero
    {

        [Key]
        
        public Guid IdGenero { get; set; }


        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "Nome do genero e obrigatorio!")]
        public string? Nome { get; set; } 


    }
}

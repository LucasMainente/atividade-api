using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Filmes_Senai.Domains
{

    [Table("Filme")]
    public class Filme
    {
        [Key]

        public Guid IdFilme { get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O Titulo do filme e obrigatorio")]


        public string? Titulo { get; set; }



        /// <summary>
        /// Referençia da tabela Genero 
        /// </summary>
        public Guid IdGenero { get; set; }

        [ForeignKey("IdGenero")]

        public Genero? Genero { get; set; }


    }
}

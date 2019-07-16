using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace demoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Titulo é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O titulo precisa ter entre 3 ou 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo data de lançamento é obrigatório")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        //[RegularExpression("@^[A-Z][a-z]+", ErrorMessage = "Genero em formato inválido")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres"), Required(ErrorMessage = "Obrigatório")]
        public string Genero { get; set; }

        [Range(1,1000, ErrorMessage = "Valor de 1 à 1000")]
        [Required(ErrorMessage = "O campo valor é obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo avaliação é obrigatório")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Numero de 0 à 5")]
        public string Avaliacao { get; set; }
    }
}

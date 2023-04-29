using System.ComponentModel.DataAnnotations;

namespace P2_2018RR604_2020CD602_2019MZ602.Models
{
    public class Generos
    {
        [Key]
        public int id_generos_ { get; set; }
        [Display(Name = "Género")]
        public string? nombre_genero { get; set; }
    }
}

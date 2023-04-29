using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P2_2018RR604_2020CD602_2019MZ602.Models
{
    public class CasosReportados
    {
        [Key]
        public int id { get; set; }
        public int? departamento_id { get; set; }
        public int? genero_id { get; set; }
        public int? confirmados { get; set; }
        public int? recuperados { get; set; }
        public int? fallecidos { get; set; }


    }
}

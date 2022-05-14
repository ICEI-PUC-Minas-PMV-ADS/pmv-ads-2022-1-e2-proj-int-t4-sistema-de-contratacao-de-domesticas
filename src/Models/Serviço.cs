using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LimpouFaxinas.Models

{
    [Table("Serviço")]
    public class Servico
    {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obritarório informar o nome!")]
        public string TipodeFaxina{ get; set; }
        [Required(ErrorMessage = "Obrigatório informar o tipo de serviço")]
    }
}
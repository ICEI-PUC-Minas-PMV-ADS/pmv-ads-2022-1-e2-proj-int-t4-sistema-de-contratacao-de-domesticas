using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;




namespace LimpouFaxinas.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o serviço desejado!")]
        public Serviço Serviço { get; set; }
    }

    public enum Serviço
    {
        Admin,
        User
    }
} 

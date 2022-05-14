using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DescarteSustentavel.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name = "Identificador do usuário"), Column("idUsuario"),
            DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int IdUsuario { get; set; }

        [Display(Name = "Nome do usuário"), Required, Column("nome")]
        public string Nome { get; set; }

        [Display(Name = "Email"), Required, Column("email")]
        public string Email { get; set; }

        [Display(Name = "Endereco"), Required, Column("endereco")]
        public string Endereco { get; set; }

        [Display(Name = "Telefone do Usuario"), Required, Column("telefone")]
        public string Telefone { get; set; }
        
        [Display(Name = "Senha do Usuario"), Required, Column("senha")]
        public string Senha { get; set; }

    }
}

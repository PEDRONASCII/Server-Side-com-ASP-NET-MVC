using System;
using System.ComponentModel.DataAnnotations;

namespace Server_Side_com_ASP_NET_MVC.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "Nome deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "RA é obrigatório")]
        public string RA { get; set; }

        [Required(ErrorMessage = "Curso é obrigatório")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é obrigatória")]
        public DateTime DataNascimento { get; set; }
    }
}
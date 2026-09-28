using System.ComponentModel.DataAnnotations;

namespace VotacaoApi.Models
{
    public class Candidato
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A turma é obrigatória.")]
        [Range(1, 8, ErrorMessage = "A turma deve ser um número entre 1 e 8.")]
        public int Turma { get; set; }

        [Required(ErrorMessage = "A descrição da proposta é obrigatória.")]
        [MaxLength(500, ErrorMessage = "A descrição da proposta deve ter no máximo 500 caracteres.")]
        public string DescricaoProposta { get; set; } = string.Empty;

        [Required(ErrorMessage = "O número do candidato é obrigatório.")]
        [Range(10, 99, ErrorMessage = "O número do candidato deve ser entre 10 e 99.")]
        public int Numero { get; set; }
    }
}
  
using System.ComponentModel.DataAnnotations;

namespace VotacaoApi.Models
{
    public class Voto
    {
        [Required(ErrorMessage = "O RA do aluno é obrigatório.")]
        public string Ra { get; set; } = string.Empty;

        [Required(ErrorMessage = "A data do voto é obrigatória.")]
        public DateTime DataVoto { get; set; }

        [Required(ErrorMessage = "O número do candidato escolhido é obrigatório.")]
        [Range(10, 99, ErrorMessage = "O número do candidato deve ser entre 10 e 99.")]
        public int NumeroCandidato { get; set; }
    }
}

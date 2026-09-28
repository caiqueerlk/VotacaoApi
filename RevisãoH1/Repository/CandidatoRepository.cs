using VotacaoApi.Models;

namespace VotacaoApi.Repository
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private readonly List<Candidato> _candidatos = new();

        public IEnumerable<Candidato> ObterTodos()
        {
            return _candidatos;
        }

        public void Adicionar(Candidato candidato)
        {
            _candidatos.Add(candidato);
        }

        public bool ExisteComNumero(int numero)
        {
            return _candidatos.Any(c => c.Numero == numero);
        }
    }
}
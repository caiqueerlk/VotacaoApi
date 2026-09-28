using VotacaoApi.Models;

namespace VotacaoApi.Repository
{
    public class VotoRepository : IVotoRepository
    {
        private readonly List<Voto> _votos = new();

        public void Adicionar(Voto voto)
        {
            _votos.Add(voto);
        }

        public IEnumerable<Voto> ObterPorCandidato(int numeroCandidato)
        {
            return _votos.Where(v => v.NumeroCandidato == numeroCandidato);
        }
    }
}
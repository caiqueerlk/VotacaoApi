using VotacaoApi.Models;

namespace VotacaoApi.Repository
{
    public interface IVotoRepository
    {
        void Adicionar(Voto voto);
        IEnumerable<Voto> ObterPorCandidato(int numeroCandidato);
    }
}
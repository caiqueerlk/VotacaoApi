using VotacaoApi.Models;

namespace VotacaoApi.Repository
{
    public interface ICandidatoRepository
    {
        IEnumerable<Candidato> ObterTodos();
        void Adicionar(Candidato candidato);
        bool ExisteComNumero(int numero);
    }
}
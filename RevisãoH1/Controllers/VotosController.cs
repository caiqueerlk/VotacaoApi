using Microsoft.AspNetCore.Mvc;
using VotacaoApi.Models;
using VotacaoApi.Repository;

namespace VotacaoApi.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class VotosController : ControllerBase
        {
            private readonly IVotoRepository _votoRepository;
            private readonly ICandidatoRepository _candidatoRepository;

            public VotosController(IVotoRepository votoRepository, ICandidatoRepository candidatoRepository)
            {
                _votoRepository = votoRepository;
                _candidatoRepository = candidatoRepository;
            }

            
            [HttpPost]
            public IActionResult RegistrarVoto(Voto voto)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (!_candidatoRepository.ExisteComNumero(voto.NumeroCandidato))
                {
                    return NotFound($"Não existe candidato cadastrado com o número {voto.NumeroCandidato}.");
                }

                _votoRepository.Adicionar(voto);

                return CreatedAtAction(nameof(ConsultarVotosPorCandidato),
                    new { numero = voto.NumeroCandidato }, voto);
            }

            
            [HttpGet("candidato/{numero}")]
            public IActionResult ConsultarVotosPorCandidato(int numero)
            {
                var votosDoCandidato = _votoRepository.ObterPorCandidato(numero);
                return Ok(votosDoCandidato);
            }
        }
    }

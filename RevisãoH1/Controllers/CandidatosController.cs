using Microsoft.AspNetCore.Mvc;
using VotacaoApi.Models;
using VotacaoApi.Repository;

namespace VotacaoApi.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class CandidatosController : ControllerBase
        {
            private readonly ICandidatoRepository _candidatoRepository;

            public CandidatosController(ICandidatoRepository candidatoRepository)
            {
                _candidatoRepository = candidatoRepository;
            }

          
            [HttpPost]
            public IActionResult CadastrarCandidato(Candidato candidato)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (_candidatoRepository.ExisteComNumero(candidato.Numero))
                {
                    return Conflict($"Já existe um candidato cadastrado com o número {candidato.Numero}.");
                }

                _candidatoRepository.Adicionar(candidato);

                return CreatedAtAction(nameof(ListarCandidatos), new { }, candidato);
            }

            
            [HttpGet]
            public IActionResult ListarCandidatos()
            {
                return Ok(_candidatoRepository.ObterTodos());
            }
        }
    }

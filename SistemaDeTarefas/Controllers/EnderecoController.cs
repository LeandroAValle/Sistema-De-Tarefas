using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoRepositorio _enderecoRepositorio;

        public EnderecoController(IEnderecoRepositorio enderecoRepositorio)
        {
            _enderecoRepositorio = enderecoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<EnderecoModel>>> BuscarTodosEnderecos()
        {
            List<EnderecoModel> endereco = await _enderecoRepositorio.BuscarTodosEnderecos();

            return Ok(endereco);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EnderecoModel>> BuscarporId(int id)
        {
            EnderecoModel endereco = await _enderecoRepositorio.BuscarPorId(id);

            return Ok(endereco);
        }

        [HttpPost]
        public async Task<ActionResult<EnderecoModel>> Cadastrar([FromBody] EnderecoModel enderecoModel)
        {
            EnderecoModel endereco = await _enderecoRepositorio.Adicionar(enderecoModel);

            return Ok(endereco);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<EnderecoModel>> Atualizar([FromBody] EnderecoModel enderecoModel, int id)
        {
            enderecoModel.Id = id;
            EnderecoModel endereco = await _enderecoRepositorio.Atualizar(enderecoModel, id);
            return Ok(endereco);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<EnderecoModel>> Apagar(int id)
        {
            bool apagado = await _enderecoRepositorio.Apagar(id);
            return Ok(apagado);
        }


    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public PessoaController(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<PessoaModel>>> BuscarTodosUsuarios()
        {
            List<PessoaModel> pessoas = await _pessoaRepositorio.BuscarTodasPessoas();

            return Ok(pessoas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PessoaModel>> BuscarporId(int id)
        {
            PessoaModel pessoas = await _pessoaRepositorio.BuscarPorId(id);

            return Ok(pessoas);
        }

        [HttpPost]
        public async Task<ActionResult<PessoaModel>> Cadastrar([FromBody] PessoaModel pessoaModel)
        {
            PessoaModel pessoas = await _pessoaRepositorio.Adicionar(pessoaModel);

            return Ok(pessoas);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PessoaModel>> Atualizar([FromBody] PessoaModel pessoaModel, int id)
        {
            pessoaModel.Id = id;
            PessoaModel pessoas = await _pessoaRepositorio.Atualizar(pessoaModel, id);
            return Ok(pessoas);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PessoaModel>> Apagar(int id)
        {
            bool apagado = await _pessoaRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}

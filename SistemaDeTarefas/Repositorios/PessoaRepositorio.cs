using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interfaces;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;

namespace SistemaDeTarefas.Repositorios
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        //para conseguir buscar o context e retornar os dados.
        private readonly SistemaTarefasDBContext _dbContext;

        ////construtor que injeta o Dbcontext
        public PessoaRepositorio(SistemaTarefasDBContext sistemaTarefasDBContext)
        {
            _dbContext = sistemaTarefasDBContext;
        }

        public async Task<PessoaModel> BuscarPorId(int id)
        {
            return await _dbContext.Pessoas.Include(X => X.Endereco).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<PessoaModel>> BuscarTodasPessoas()
        {
            return await _dbContext.Pessoas.Include(X => X.Endereco).ToListAsync();
        }

        public async Task<PessoaModel> Adicionar(PessoaModel pessoa)
        {
            await _dbContext.Pessoas.AddAsync(pessoa);
            await _dbContext.SaveChangesAsync();

            return pessoa;
        }

        public async Task<bool> Apagar(int id)
        {
            PessoaModel pessoaId = await BuscarPorId(id);

            if (pessoaId == null)
            {
                throw new Exception($"Pessoa para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Pessoas.Remove(pessoaId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<PessoaModel> Atualizar(PessoaModel pessoa, int id)
        {
            PessoaModel pessoaId = await BuscarPorId(id);

            if (pessoaId == null)
            {
                throw new Exception($"Pessoa para o ID: {id} não foi encontrado no banco de dados.");
            }

            pessoaId.Nome = pessoa.Nome;
            pessoaId.Nis = pessoa.Nis;
            pessoaId.Sexo = pessoa.Sexo;
            pessoaId.Data_nascimento = pessoa.Data_nascimento;
            pessoaId.Nacionalidade = pessoa.Nacionalidade;
            pessoaId.Nome_pai = pessoa.Nome_pai;
            pessoaId.Nome_mae = pessoa.Nome_mae;
            pessoaId.Estado_civil = pessoa.Estado_civil;
            pessoaId.Escolaridade = pessoa.Escolaridade;
            pessoaId.Serie_escolar = pessoa.Serie_escolar;
            pessoaId.UnidadeEscolar = pessoa.UnidadeEscolar;
            pessoaId.Tipo_escola = pessoa.Tipo_escola;
            pessoaId.Cor = pessoa.Cor;
            pessoaId.Certidao_nascimento = pessoa.Certidao_nascimento;
            pessoaId.CPF = pessoa.CPF;
            pessoaId.RG = pessoa.RG;
            pessoaId.Data_cadastro = pessoa.Data_cadastro;
            pessoaId.Endereco = pessoa.Endereco;
            pessoaId.Numero = pessoa.Numero;
            pessoaId.Bairro = pessoa.Bairro;
            pessoaId.CEP = pessoa.CEP;
            pessoaId.Telefone = pessoa.Telefone;
            pessoaId.UF = pessoa.UF;
            pessoaId.Cidade = pessoa.Cidade;
            pessoaId.Reservista = pessoa.Reservista;
            pessoaId.Titulo_eleitor = pessoa.Titulo_eleitor;
            pessoaId.Zona = pessoa.Zona;
            pessoaId.Secao = pessoa.Secao;
            pessoaId.UF_nascimento = pessoa.UF_nascimento;
            pessoaId.Cidade_nascimento = pessoa.Cidade_nascimento;
            pessoaId.Telefone_pessoal = pessoa.Telefone_pessoal;
            pessoaId.Emissao_rg = pessoa.Emissao_rg;
            pessoaId.UF_rg = pessoa.UF_rg;
            pessoaId.Orgao = pessoa.Orgao;

            _dbContext.Pessoas.Update(pessoaId);
            await _dbContext.SaveChangesAsync();

            return pessoaId;
        }

    }
}

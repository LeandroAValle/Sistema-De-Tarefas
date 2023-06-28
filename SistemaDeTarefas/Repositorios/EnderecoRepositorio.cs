using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Repositorios
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private readonly SistemaTarefasDBContext _dbContext;

        public EnderecoRepositorio(SistemaTarefasDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<EnderecoModel> Adicionar(EnderecoModel endereco)
        {
            await _dbContext.Enderecos.AddAsync(endereco);
            await _dbContext.SaveChangesAsync();

            return endereco;
        }

        public async Task<bool> Apagar(int id)
        {

            EnderecoModel enderecoPorId = await BuscarPorId(id);

            if (enderecoPorId == null)
            {
                throw new Exception($"Endereço para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Enderecos.Remove(enderecoPorId);
            await _dbContext.SaveChangesAsync();

            return true;

        }

        public async Task<EnderecoModel> Atualizar(EnderecoModel endereco, int id)
        {
            EnderecoModel enderecoPorId = await BuscarPorId(id);

            if (enderecoPorId == null)
            {
                throw new Exception($"Endereço para o ID: {id} não foi encontrado no banco de dados.");
            }

            enderecoPorId.Descricao = endereco.Descricao;
            
            _dbContext.Enderecos.Update(enderecoPorId);
            await _dbContext.SaveChangesAsync();

            return enderecoPorId;
        }

        public async Task<EnderecoModel> BuscarPorId(int id)
        {
            return await _dbContext.Enderecos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<EnderecoModel>> BuscarTodosEnderecos()
        {
            return await _dbContext.Enderecos.ToListAsync();
        }
    }
}

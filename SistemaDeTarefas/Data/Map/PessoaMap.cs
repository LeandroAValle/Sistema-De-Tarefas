using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data.Map
{
    public class PessoaMap : IEntityTypeConfiguration<PessoaModel>
    {
        public void Configure(EntityTypeBuilder<PessoaModel> builder)
        {
            //Haskey = chave primaria
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            //builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Familia);
            builder.Property(x => x.Nis);
            builder.Property(x => x.Parentesco);
            builder.Property(x => x.Responsavel_familiar);
            builder.Property(x => x.Sexo);
            builder.Property(x => x.Data_nascimento);
            builder.Property(x => x.Nacionalidade);
            builder.Property(x => x.Nome_pai);
            builder.Property(x => x.Nome_mae);
            builder.Property(x => x.Estado_civil);
            builder.Property(x => x.Escolaridade);
            builder.Property(x => x.Serie_escolar);
            builder.Property(x => x.UnidadeEscolar);
            builder.Property(x => x.Tipo_escola);
            builder.Property(x => x.Cor);
            builder.Property(x => x.Certidao_nascimento);
            builder.Property(x => x.CPF);
            builder.Property(x => x.RG);
            builder.Property(x => x.Data_cadastro);
            builder.Property(x => x.Numero);
            builder.Property(x => x.Bairro);
            builder.Property(x => x.CEP);
            builder.Property(x => x.Telefone);
            builder.Property(x => x.UF);
            builder.Property(x => x.Cidade);
            builder.Property(x => x.Reservista);
            builder.Property(x => x.Titulo_eleitor);
            builder.Property(x => x.Zona);
            builder.Property(x => x.Secao);
            builder.Property(x => x.UF_nascimento);
            builder.Property(x => x.Cidade_nascimento);
            builder.Property(x => x.Telefone_pessoal);
            builder.Property(x => x.Emissao_rg);
            builder.Property(x => x.UF_rg);
            builder.Property(x => x.Orgao);

            //builder.Property(x => x.EnderecoId);

            builder.HasOne(x => x.Endereco);
        }
    }
}

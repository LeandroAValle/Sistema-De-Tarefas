using SistemaDeTarefas.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using static SistemaDeTarefas.Enums.SexoPessoa;

namespace SistemaDeTarefas.Models
{
    [Table("Pessoas")]
    public class PessoaModel
    {
        public int Id { get; set; }
        public int? Familia { get; set; }
        public string? Nome { get; set; }
        public string? Nis { get; set; }
        public int? Parentesco { get; set; }
        public int? Responsavel_familiar { get; set; }
        public SexoPessoa Sexo { get; set; }
        public DateTime? Data_nascimento { get; set; }
        public int? Nacionalidade { get; set; }
        public string? Nome_pai { get; set; }
        public string? Nome_mae { get; set; }
        public int? Estado_civil { get; set; }
        public int? Escolaridade { get; set; }
        public int? Serie_escolar { get; set; }
        public int? UnidadeEscolar { get; set; }
        public int? Tipo_escola { get; set; }
        public int? Cor { get; set; }
        public string? Certidao_nascimento { get; set; }
        public String? CPF { get; set; }
        public String? RG { get; set; }
        public DateTime? Data_cadastro { get; set; }
        public string? Numero { get; set; }
        public int? Bairro { get; set; }
        public String? CEP { get; set; }
        public String? Telefone { get; set; }
        public int? UF { get; set; }
        public int? Cidade { get; set; }
        public String? Reservista { get; set; }
        public String? Titulo_eleitor { get; set; }
        public String? Zona { get; set; }
        public String? Secao { get; set; }
        public int? UF_nascimento { get; set; }
        public int? Cidade_nascimento { get; set; }
        public String? Telefone_pessoal { get; set; }
        public DateTime? Emissao_rg { get; set; }
        public string? UF_rg { get; set; }
        public string? Orgao { get; set; }

        [ForeignKey("Endereco")]
        [Column(Order = 1)]
        public int EnderecoId { get; set; }
        public virtual EnderecoModel Endereco { get; set; }


    }
}

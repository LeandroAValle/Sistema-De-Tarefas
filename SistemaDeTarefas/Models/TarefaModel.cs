using SistemaDeTarefas.Enums;
using System.Xml.Linq;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace SistemaDeTarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }

        //Adciona mais uma linha abaixo com a descrição
        //public string StatusNameDescription
        //{
        //    get
        //    {
        //        var type = typeof(StatusTarefa);
        //        var member = type.GetMember(Status.ToString());
        //        var attributes = member[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

        //        return ((DescriptionAttribute)attributes[0]).Description;
        //    }
        //}

        public int? UsuarioId { get; set; }
        public virtual UsuarioModel? Usuario { get; set; }
        
    }
}

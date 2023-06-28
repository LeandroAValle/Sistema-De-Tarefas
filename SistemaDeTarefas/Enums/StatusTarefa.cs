using System.ComponentModel;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace SistemaDeTarefas.Enums
{
    //Já tras somente a descrição
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusTarefa
    {
        [Description("A Fazer")]
        AFazer = 1,
        [Description("Em Andamento")]
        EmAndamento = 2,
        [Description("Concuido")]
        Concuido = 3

    }
}

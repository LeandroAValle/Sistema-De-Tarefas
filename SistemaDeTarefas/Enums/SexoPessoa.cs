using System.ComponentModel;
using System.Text.Json.Serialization;

namespace SistemaDeTarefas.Enums
{
    //Já tras somente a descrição
    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum SexoPessoa
    {
        [Description("Masculino")]
        Masculino = 0,
        [Description("Feminino")]
        Feminino = 1
    }

}

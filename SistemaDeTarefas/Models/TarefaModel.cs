using SistemaDeTarefas.Enums;

namespace SistemaDeTarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public StatusTarefaEnum StatusTarefa { get; set; }   
    }
}

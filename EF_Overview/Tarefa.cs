
namespace EF_Overview;
public class Tarefa
{    
    public Guid Id { get; set; }
    public string? Titulo { get; set; }
    public string? Descricao { get; set; }
    public DateTime DataConclusao { get; set; }
    public bool Concluida { get; set; }

    override public string ToString()
    {
       return $"Id: {Id} ,\n Titulo: {Titulo},\n Descricao: {Descricao}, DataConclusao: {DataConclusao},\n Concluida: {Concluida}";
    }

}

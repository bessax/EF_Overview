using EF_Overview;

var context = new TarefasContext();
#region Cadastro de tarefas
//var tarefas = new List<Tarefa>
//{
//    new Tarefa
//    {
//        Id = Guid.NewGuid(),
//        Titulo = "Estudar Entity Framework",
//        Descricao = "Estudar Entity Framework Core",
//        DataConclusao = DateTime.Now.AddDays(1),
//        Concluida = false
//    },
//    new Tarefa
//    {
//        Id = Guid.NewGuid(),
//        Titulo = "Estudar C#",
//        Descricao = "Estudar C#",
//        DataConclusao = DateTime.Now.AddDays(2),
//        Concluida = false
//    }
//};


//// Adiciona a tarefa ao contexto
//context.Tarefas.AddRange(tarefas);
//context.SaveChanges();
#endregion 

# region Consulta todas as tarefas
//var consultaTarefas = context.Tarefas.ToList();
//foreach (var item in consultaTarefas)
//{
//    Console.WriteLine(item.Id);
//    Console.WriteLine(item.Titulo);
//    Console.WriteLine(item.Descricao);
//    Console.WriteLine(item.DataConclusao);
//    Console.WriteLine(item.Concluida);
//}
//Console.ReadKey();
#endregion

#region Consulta tarefa por Id

var tarefa = context.Tarefas.Find(Guid.Parse("0ac039f8-8f64-47a6-becd-07768e3f8c12"));

//if (tarefa != null)
//{
//    Console.WriteLine(tarefa.ToString());
//}
//else
//{
//    Console.WriteLine("Tarefa não encontrada");
//}

if (tarefa != null)
{
    context.Tarefas.Remove(tarefa);
    context.SaveChanges();

}

#endregion
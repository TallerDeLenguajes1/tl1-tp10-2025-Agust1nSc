using System.Text.Json;
using EspacioTareas;

HttpClient client = new HttpClient();

string url = "https://jsonplaceholder.typicode.com/todos/";

string cuerpo = await client.GetStringAsync(url);

List<Tarea> tareas = JsonSerializer.Deserialize<List<Tarea>>(cuerpo);

foreach (var tareaAux in tareas.Where(tareaAux => !tareaAux.completed))
{
    Console.WriteLine("Tarea:" + tareaAux.title + "Estado: Pendiente");
}

foreach (var tareaAux in tareas.Where(tareaAux => tareaAux.completed))
{
    Console.WriteLine("Tarea:" + tareaAux.title + "Estado: Realizada");
}

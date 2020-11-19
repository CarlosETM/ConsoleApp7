using System;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
         static  void Main(string[] args)
        {
             valor();
            Console.WriteLine("Hello World!");
        }

        public  async static Task valor() 
        {
            Task<int> myTask = Task.FromResult(1000);

            // Podemos consultar el estado
            // Los posibles valores están definidos en el enum TaskStatus
            var taskStatus = myTask.Status;

            // Existen propiedades booleanas para controlar los estados
            var isTaskFaulted = myTask.IsFaulted;
            var isTaskCanceled = myTask.IsCanceled;
            var isTaskCompleted = myTask.IsCompleted;

            // Esperaremos a que terminen las tareas usando await
            var awaitedResult = await myTask;

            // Nunca en código asíncrono lo haremos de esta forma
            myTask.Wait();
            var result = myTask.Result;
        }
    }
}

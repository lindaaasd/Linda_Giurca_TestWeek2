using System;
using System.Collections;
using Week2.Esercitazione.Entities;

namespace Week2.Esercitazione
{
	internal static class GestioneTasks
	{
		internal static Task InserisciTask()
        {
			Task task = new Task();

            Console.WriteLine("Inserisci la descrizione del task");
            task.Description = Console.ReadLine();

            Console.WriteLine("Inserisci il deadline del task ( format dd/MM/yyyy )");
			DateTime.TryParse(Console.ReadLine(), out DateTime expiryDate);
			task.ExpiryDate = expiryDate;

			Console.WriteLine("Inserisci la priorità del task // basso; medio; alto //");
			task.Priority = Console.ReadLine();

			return task;
				
		}

        public static void StampaTasks(ArrayList tasks)
        {
			foreach (Task task in tasks)
			{
				Console.WriteLine($"{task.Description} con scadenza {task.ExpiryDate} \n" +
                    $"Priorità: {task.Priority}");
			}
		}

		public static void EliminaTask(ArrayList tasks)
        {
			Task taskDaCancellare = FiltraTask(tasks);

			if (taskDaCancellare != null)
            {
				tasks.Remove(taskDaCancellare);
                Console.WriteLine("Task cancellato ");
				Console.ReadLine();
            } else
            {
                Console.WriteLine("Task non trovato");
            }
        }

		public static Task FiltraTask(ArrayList tasks)
        {
            Console.WriteLine("Inserisci la descrizione del task: ");
			string descriptionTask = Console.ReadLine();

			foreach (Task task in tasks)
			{
	
				if (task.Description == descriptionTask)
				{
					return task; 
				}

			}
			return null;

		}

        public static void FiltraTaskPriorita(ArrayList tasks)
        {
            Console.WriteLine("Inserisci la priorita dei task che vuoi vedere: ");
            string priorityTask = Console.ReadLine();

			foreach (Task task in tasks)
            {
				if(task.Priority == priorityTask)
                {
                    Console.WriteLine($"Le task da fare con la priorità {priorityTask} sono: \n {task.Description} " +
                        $"e scadenza {task.ExpiryDate}");
                }
            }
			
        }




    }
}


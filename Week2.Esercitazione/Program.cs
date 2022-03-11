using System;
using System.Collections;

namespace Week2.Esercitazione
{
    //ESERCIZIO 1:
    //string nome = “Mario”; 	ASSEGNAZIONE
    //int i; DICHIARAZIONE
    ////isInt = true; INIZZIALIZAZIONE
    //ES 2: B. RIFERIMENTO
    //ES 3: C.
    //ES 4: C.


    class Program
    {
        static void Main(string[] args)
        {
         

            ArrayList listaTasks = new ArrayList();
            bool continua = true;

            while (continua)
            {
                int scelta = TaskMenu();
                switch (scelta)
                {
                    case 1:
                        //visualizzare i tasks
                        GestioneTasks.StampaTasks(listaTasks);
                        break;
                    case 2:
                        //aggiungere un nuovo task
                        listaTasks.Add(GestioneTasks.InserisciTask());
                        break;
                    case 3:
                        //eliminare un task esistente
                        GestioneTasks.EliminaTask(listaTasks);
                        break;
                    case 4:
                        //filtrare i tasks per livello di priorità
                        GestioneTasks.FiltraTaskPriorita(listaTasks);
                        break;
                    case 5:
                        //scrivi l'elenco dei task su un file txt
                        TasksIO.ScriviTaskSuFile(listaTasks);
                        break;
                    case 6:
                        //carica l'elenco dei task da un file txt
                        TasksIO.StampaTasksDaFile();
                        GestioneTasks.StampaTasks(listaTasks)
                        break;
                    default:
                        continua = false;
                        Console.WriteLine("Arrivederci");
                        break;
                }
            }

        }

        public static int TaskMenu()
        {
            Console.WriteLine("1. Visualizza i tasks");
            Console.WriteLine("2. Aggiungi nuovo task");
            Console.WriteLine("3. Elimina un task");
            Console.WriteLine("4. Filtra i task per priorità // basso; medio; alto //");
            Console.WriteLine("5. Carica l'elenco dei task su un file txt");
            Console.WriteLine("6. Stampa l'elenco dei task dal file");
            Console.Write("Scelta: >");
            Int32.TryParse(Console.ReadLine(), out int scelta);
            return scelta;
        }
    }
}


using System;
using System.Collections;
using System.IO;
using Week2.Esercitazione.Entities;

namespace Week2.Esercitazione
{
	internal static class TasksIO
	{
		public static void ScriviTaskSuFile(ArrayList tasks)
        {
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "tasks.txt");

            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (var taskDaStampareSuFile in tasks)
                {
                    sw.WriteLine(taskDaStampareSuFile);
                }
            }
        }

        public static ArrayList StampaTasksDaFile()
        {
            ArrayList tasksCaricateDaFile = new ArrayList();

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "tasks.txt");
            string line;
            using (StreamReader sr = File.OpenText(path))
            {
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] valoriTasks = line.Split('-');
                    string descrizione = valoriTasks[0];
                    string correctDescription = descrizione;

                    string priority = valoriTasks[1];

                    var correctExpiryDate = valoriTasks[2];
                    DateTime.TryParse(valoriTasks[2], out DateTime expiryDate);


                    Task t = new Task()
                    {
                        Description = descrizione,
                        ExpiryDate = Convert.ToDateTime(correctExpiryDate),
                        Priority = priority,

                    };

                    tasksCaricateDaFile.Add(t);
                    line = sr.ReadLine();
                }
            }

            return tasksCaricateDaFile;
        }


    }
}


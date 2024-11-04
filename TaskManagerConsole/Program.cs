using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        TaskRepository taskRepo = new TaskRepository();
        while (true)
        {
            Console.WriteLine("\n--- Gestionnaire de Tâches ---");
            Console.WriteLine("1. Ajouter une tâche");
            Console.WriteLine("2. Modifier une tâche");
            Console.WriteLine("3. Supprimer une tâche");
            Console.WriteLine("4. Afficher toutes les tâches");
            Console.WriteLine("5. Rechercher une tâche par ID");
            Console.WriteLine("0. Quitter");

            Console.Write("Sélectionnez une option : ");
            string? choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    AddTask(taskRepo);
                    break;
                case "2":
                    UpdateTask(taskRepo);
                    break;
                case "3":
                    DeleteTask(taskRepo);
                    break;
                case "4":
                    ShowAllTasks(taskRepo);
                    break;
                case "5":
                    SearchTask(taskRepo);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }
        }
    }

    static void AddTask(TaskRepository repo)
    {
        Console.Write("Titre : ");
        string title = Console.ReadLine() ?? "Sans titre";

        Console.Write("Description : ");
        string description = Console.ReadLine() ?? "Pas de description";

        repo.AddTask(new Task { Title = title, Description = description });
        Console.WriteLine("Tâche ajoutée !");
    }

    static void UpdateTask(TaskRepository repo)
    {
        Console.Write("ID de la tâche à modifier : ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            Console.Write("Nouveau Titre : ");
            string newTitle = Console.ReadLine() ?? string.Empty;

            Console.Write("Nouvelle Description : ");
            string newDescription = Console.ReadLine() ?? string.Empty;

            Console.Write("Statut (terminé : true/false) : ");
            if (bool.TryParse(Console.ReadLine(), out bool isCompleted))
            {
                repo.UpdateTask(id, newTitle, newDescription, isCompleted);
                Console.WriteLine("Tâche mise à jour !");
            }
            else
            {
                Console.WriteLine("Statut invalide. La tâche n'a pas été mise à jour.");
            }
        }
        else
        {
            Console.WriteLine("ID invalide.");
        }
    }

    static void DeleteTask(TaskRepository repo)
    {
        Console.Write("ID de la tâche à supprimer : ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            repo.DeleteTask(id);
            Console.WriteLine("Tâche supprimée !");
        }
        else
        {
            Console.WriteLine("ID invalide.");
        }
    }

    static void ShowAllTasks(TaskRepository repo)
    {
        List<Task> tasks = repo.GetAllTasks();
        foreach (var task in tasks)
        {
            Console.WriteLine($"ID: {task.Id} | Titre: {task.Title} | Terminé: {task.IsCompleted}");
        }
    }

    static void SearchTask(TaskRepository repo)
    {
        Console.Write("ID de la tâche à rechercher : ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            Task? task = repo.GetTaskById(id);
            if (task != null)
            {
                Console.WriteLine($"ID: {task.Id} | Titre: {task.Title} | Description: {task.Description} | Terminé: {task.IsCompleted}");
            }
            else
            {
                Console.WriteLine("Tâche non trouvée.");
            }
        }
        else
        {
            Console.WriteLine("ID invalide.");
        }
    }
}

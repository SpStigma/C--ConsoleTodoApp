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
            string choix = Console.ReadLine();

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
        string title = Console.ReadLine();

        Console.Write("Description : ");
        string description = Console.ReadLine();

        repo.AddTask(new Task { Title = title, Description = description });
        Console.WriteLine("Tâche ajoutée !");
    }

    static void UpdateTask(TaskRepository repo)
    {
        Console.Write("ID de la tâche à modifier : ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Nouveau Titre : ");
        string newTitle = Console.ReadLine();

        Console.Write("Nouvelle Description : ");
        string newDescription = Console.ReadLine();

        Console.Write("Statut (terminé : true/false) : ");
        bool isCompleted = bool.Parse(Console.ReadLine());

        repo.UpdateTask(id, newTitle, newDescription, isCompleted);
        Console.WriteLine("Tâche mise à jour !");
    }

    static void DeleteTask(TaskRepository repo)
    {
        Console.Write("ID de la tâche à supprimer : ");
        int id = int.Parse(Console.ReadLine());

        repo.DeleteTask(id);
        Console.WriteLine("Tâche supprimée !");
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
        int id = int.Parse(Console.ReadLine());

        Task task = repo.GetTaskById(id);
        if (task != null)
        {
            Console.WriteLine($"ID: {task.Id} | Titre: {task.Title} | Description: {task.Description} | Terminé: {task.IsCompleted}");
        }
        else
        {
            Console.WriteLine("Tâche non trouvée.");
        }
    }
}

# C--ConsoleTodoApp

Application console de gestion de tâches (ToDo List) en C#.

## Table of Contents

* [About The Project](#about-the-project)
* [Built With](#built-with)
* [Getting Started](#getting-started)

  * [Prerequisites](#prerequisites)
  * [Installation](#installation)
* [Usage](#usage)
* [Contributing](#contributing)

## About The Project

C--ConsoleTodoApp est une application console simple écrite en C# permettant de gérer une liste de tâches.
Elle offre un menu interactif pour :

* Ajouter une tâche avec description et priorité.
* Afficher toutes les tâches (triées par priorité).
* Marquer une tâche comme “terminée”.
* Modifier la description ou la priorité d’une tâche existante.
* Supprimer une tâche.
* Quitter l’application.

L’objectif du projet est d’illustrer la programmation orientée objet en C#, la manipulation de collections génériques et la gestion d’une interface console basique.

---

## Built With

* [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0)
* C# (programmation orientée objet)
* Collections génériques (`List<T>`)
* Interface console (I/O via `Console.ReadLine()` / `Console.WriteLine()`)

---

## Getting Started

Suivez ces instructions pour cloner, compiler et exécuter l’application en local.

### Prerequisites

* .NET 6 SDK ou version ultérieure installé sur votre machine
* Git

### Installation

1. Cloner le dépôt :

   ```bash
   git clone https://github.com/SpStigma/C--ConsoleTodoApp.git
   ```
2. Positionnez-vous dans le répertoire du projet :

   ```bash
   cd C--ConsoleTodoApp
   ```
3. Exécuter l’application :

   ```bash
   dotnet run
   ```

---

## Usage

Une fois l’application démarrée (via la commande `dotnet run`), vous serez accueilli par un menu interactif dans la console. Voici un aperçu des différentes fonctionnalités et de leur utilisation :

1. **Ajouter une tâche**

   * Sélectionnez l’option « Ajouter une tâche » en entrant le chiffre correspondant.
   * Saisissez la description de la tâche lorsque vous y êtes invité.
   * Choisissez une priorité (par exemple, 1 pour haute, 2 pour moyenne, 3 pour basse).
   * La tâche est alors enregistrée avec un identifiant unique et l’état « En cours ».

2. **Afficher toutes les tâches**

   * Sélectionnez l’option « Afficher toutes les tâches ».
   * Toutes les tâches seront listées, triées par priorité (de la plus haute à la plus basse).
   * Chaque ligne affiche :

     * L’identifiant de la tâche
     * La description
     * La priorité
     * L’état (En cours ou Terminée)

3. **Marquer une tâche comme terminée**

   * Sélectionnez l’option « Marquer une tâche comme terminée ».
   * Saisissez l’identifiant de la tâche à terminer.
   * L’état de la tâche passe alors à « Terminée ».

4. **Modifier une tâche existante**

   * Sélectionnez l’option « Modifier une tâche ».
   * Saisissez l’identifiant de la tâche que vous souhaitez modifier.
   * Le programme vous demandera d’entrer une nouvelle description (vous pouvez la laisser vide si vous ne souhaitez pas la changer), puis une nouvelle priorité (laissez le même numéro pour ne pas la modifier).
   * Les champs mis à jour sont enregistrés.

5. **Supprimer une tâche**

   * Sélectionnez l’option « Supprimer une tâche ».
   * Entrez l’identifiant de la tâche à supprimer.
   * La tâche est alors définitivement retirée de la liste.

6. **Quitter l’application**

   * Sélectionnez l’option « Quitter ».
   * L’application se ferme proprement. Toutes les données en mémoire sont perdues, car il s’agit d’une application console ne persistant pas sur disque par défaut.

---

## Contributing

Les contributions à ce projet sont les bienvenues ! Voici quelques lignes directrices si vous souhaitez participer :

1. **Signaler un bug**

   * Ouvrez une *Issue* sur le dépôt GitHub en décrivant clairement le problème rencontré, les étapes pour le reproduire et, si possible, un exemple de sortie ou un message d’erreur.
   * Veillez à vérifier si une issue similaire n’existe pas déjà avant de créer la vôtre.

2. **Proposer une fonctionnalité**

   * Ouvrez une *Issue* pour présenter votre idée. Expliquez le besoin, le comportement attendu et pourquoi cette fonctionnalité serait utile.
   * Les mainteneurs pourront alors discuter de la faisabilité et vous orienter sur la meilleure approche.

3. **Soumettre une pull request**

   * Forkez le dépôt sur GitHub et clonez votre fork.
   * Créez une branche dédiée à votre correctif ou nouvelle fonctionnalité :

     ```bash
     git checkout -b feature/ma-nouvelle-fonctionnalite
     ```
   * Apportez vos modifications en respectant les bonnes pratiques C# (noms de classes en PascalCase, camelCase pour les variables, etc.), et sans utiliser d’opérateurs ternaires pour la lisibilité.
   * Testez votre code localement en exécutant l’application et en vérifiant que tout fonctionne comme prévu.
   * Commitez vos changements avec un message clair :

     ```bash
     git add .
     git commit -m "Ajout de la fonctionnalité X : explication concise"
     ```
   * Poussez votre branche sur votre fork et ouvrez une pull request vers la branche `main` du dépôt principal.
   * Décrivez dans la PR les changements effectués, les raisons et, si nécessaire, des instructions pour tester la nouvelle fonctionnalité.

4. **Conventions de style**

   * C# : suivez la [convention officielle Microsoft](https://docs.microsoft.com/dotnet/csharp/fundamentals/coding-style/coding-conventions) pour le nommage et l’organisation du code.
   * Ne pas utiliser d’opérateur ternaire (`condition ? valeur1 : valeur2`) – privilégiez plutôt des structures `if…else` pour une meilleure clarté.
   * Indentez avec 4 espaces (pas de tabulations).
   * Commentez suffisamment votre code pour expliquer la logique lorsque cela est nécessaire, mais évitez les commentaires superflus.

5. **Tests (le cas échéant)**

   * Si vous ajoutez une nouvelle fonctionnalité complexe ou un correctif critique, pensez à écrire des tests unitaires.
   * Vous pouvez utiliser un framework de test comme xUnit ou NUnit.
   * Placez les tests dans un projet de tests séparé (`ConsoleTodoApp.Tests`) et assurez-vous qu’ils passent avant de soumettre la PR.

6. **Code Review et Validation**

   * Une fois la pull request ouverte, un mainteneur passera en revue vos modifications.
   * Vous pourriez recevoir des commentaires pour améliorer ou ajuster certaines parties.
   * Merci de répondre aux retours avec courtoisie et d’apporter les ajustements demandés.

---

> *Merci d’avoir consulté ce projet ! N’hésitez pas à contribuer ou à me contacter pour toute question.*
